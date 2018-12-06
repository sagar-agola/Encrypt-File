using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using Encrypt_Library;

namespace EncryptFile
{
    public partial class EncryptFile : Form
    {
        bool IsEncrypt;
        int Key;
        String inputFileURL;
        String outputFileName;
        String DecryptFileURL;

        public EncryptFile()
        {
            InitializeComponent ();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit ();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnAsk_Click(object sender, EventArgs e)
        {
            MessageBox.Show ("follow following steps." + Environment.NewLine +
                "1. select Text file you went to encrypt using 'select file' button." + Environment.NewLine +
                "2. Enter file name you went to give to encrypted file in second text box." + Environment.NewLine +
                "3. New file will be created in C drive with name you entered." + Environment.NewLine + "Thank you!",
                "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        //------------------Handle application flow-----------------------
        private void EncryptFile_Load(object sender, EventArgs e)
        {
            lblStatues.Text = String.Empty;
            radioEncrypt.Checked = true;
            IsEncrypt = true;
        }
        private void radioEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (radioEncrypt.Checked)
            {
                btnEncryptDecrypt.Text = "Encrypt";
                IsEncrypt = true;
                panelEncrypt.Visible = true;
                panelDecrypt.Visible = false;
            }
            else
            {
                btnEncryptDecrypt.Text = "Decrypt";
                IsEncrypt = false;
                panelEncrypt.Visible = false;
                panelDecrypt.Visible = true;
            }
        }
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            //Get URL of file
            OpenFileDialog ofd = new OpenFileDialog ();
            ofd.Title = "Select File";
            ofd.Filter = "Text | *.txt";
            if (IsEncrypt)
            { 
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    txtFileURL.Text = ofd.FileName;
                }
            }
            else
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    txtSelectFileURLDecrypt.Text = ofd.FileName;
                }
            }
        }
        private void btnEncryptDecrypt_Click(object sender, EventArgs e)
        {
            if(IsEncrypt)
            {
                inputFileURL = txtFileURL.Text;
                if (ValidEncryptInputs)
                {
                    outputFileName = txtNewFileName.Text;
                    Random random = new Random ();
                    Key = random.Next (0, 9);

                    EncryptUserFile (inputFileURL, outputFileName);
                }
            }
            else
            {
                DecryptFileURL = txtSelectFileURLDecrypt.Text;
                if (ValidDecryptInputs)
                    DecryptUserFile (@DecryptFileURL, int.Parse (txtKey.Text));
            }
        }
        //----------------Encryption or Decryption of user file-----------------
        private void DecryptUserFile(string filePath, int DecryptionKey)
        {
            try
            {
                String text = File.ReadAllText (@filePath);
                String [] words = text.Split (' ');
                int i = 0;

                foreach (String word in words)
                {
                    words [i] = BusinessLogic.Decrypt (word, DecryptionKey);
                    i++;
                }
                String txt = String.Join (" ", words);
                if(File.Exists(@filePath))
                {
                    File.Delete (@filePath);
                }
                File.WriteAllText (@filePath, txt);

                DialogResult userAnswer = MessageBox.Show ("Your file Decrypted and saved to following location."
                    + Environment.NewLine + filePath + Environment.NewLine + "Would you like to open file?"
                    , "Done", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if(userAnswer == DialogResult.Yes)
                {
                    Process.Start (filePath);
                }
                lblStatues.Text = "File Decrypted successfully :)";
                lblStatues.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatues.Text = "File could not be Decrypted :(...Please try Again!";
                lblStatues.ForeColor = Color.Red;
            }
        }
        private void EncryptUserFile(string inputFileURL, string outputFileName)
        {
            try
            {
                String text = File.ReadAllText (@inputFileURL);
                String [] words = text.Split (' ');
                int i = 0;

                foreach (String word in words)
                {
                    words [i] = BusinessLogic.Encrypt (word, Key);
                    i++;
                }
                String txt = String.Join (" ", words);
                File.WriteAllText (@"C:/" + outputFileName + ".txt", txt);

                DialogResult userAnswer = MessageBox.Show ("Your file Encrypted and saved to following location." + Environment.NewLine
                    + @"C:/" + outputFileName + ".txt" + Environment.NewLine + "Your Decryption key is "
                    + Key.ToString() + ". Keep it safe." + Environment.NewLine + "Would you like to open file?" , "Done", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if(userAnswer == DialogResult.Yes)
                {
                    Process.Start (@"C:/" + outputFileName + ".txt");
                }
                lblStatues.Text = "File Encrypted successfully :)";
                lblStatues.ForeColor = Color.Green;
            }
            catch(Exception ex)
            {
                MessageBox.Show (ex.Message, "Unhendled exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(File.Exists(@"C:/" + outputFileName + ".txt"))
                {
                    File.Delete (@"C:/" + outputFileName + ".txt");
                }
                lblStatues.Text = "Encryption could not be done! Try again.";
                lblStatues.ForeColor = Color.Red;
            }
        }
        //-----------Validation-----------
        private bool ValidEncryptInputs
        {
            get
            {
                if (String.IsNullOrEmpty (txtFileURL.Text))
                {
                    lblStatues.Text = "Please select file first :(";
                    lblStatues.ForeColor = Color.Red;

                    return false;
                }
                else if (String.IsNullOrEmpty (txtNewFileName.Text))
                {
                    lblStatues.Text = "Please enter valid file name :(";
                    lblStatues.ForeColor = Color.Red;

                    return false;
                }
                else
                {
                    lblStatues.Text = "Valid input :)";
                    lblStatues.ForeColor = Color.Green;

                    return true;
                }
            }
        }
        private bool ValidDecryptInputs
        {
            get
            {
                if (String.IsNullOrEmpty (txtSelectFileURLDecrypt.Text))
                {
                    lblStatues.Text = "Please select file first :(";
                    lblStatues.ForeColor = Color.Red;

                    return false;
                }
                else if (String.IsNullOrEmpty (txtKey.Text))
                {
                    lblStatues.Text = "Please enter Key value :(";
                    lblStatues.ForeColor = Color.Red;

                    return false;
                }
                else
                {
                    lblStatues.Text = "Valid input :)";
                    lblStatues.ForeColor = Color.Green;

                    return true;
                }
            }

        }
        //-------------Logic for Encryption and decryption----------------
    }
}