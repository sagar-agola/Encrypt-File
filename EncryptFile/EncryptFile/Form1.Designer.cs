namespace EncryptFile
{
    partial class EncryptFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnAsk = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnEncryptDecrypt = new System.Windows.Forms.Button();
            this.txtFileURL = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNewFileName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblStatues = new System.Windows.Forms.Label();
            this.radioEncrypt = new System.Windows.Forms.RadioButton();
            this.radioDecrypt = new System.Windows.Forms.RadioButton();
            this.panelEncrypt = new System.Windows.Forms.Panel();
            this.panelDecrypt = new System.Windows.Forms.Panel();
            this.txtSelectFileURLDecrypt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtKey = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dragControl1 = new DragControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelEncrypt.SuspendLayout();
            this.panelDecrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 5);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(522, 5);
            this.panel2.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Navy;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(522, 5);
            this.panel6.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 209);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(522, 1);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Navy;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 204);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Navy;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(521, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 204);
            this.panel5.TabIndex = 4;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelHeader.Controls.Add(this.btnAsk);
            this.panelHeader.Controls.Add(this.btnMinimize);
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(1, 5);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(520, 30);
            this.panelHeader.TabIndex = 5;
            // 
            // btnAsk
            // 
            this.btnAsk.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAsk.FlatAppearance.BorderSize = 0;
            this.btnAsk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsk.Location = new System.Drawing.Point(430, 0);
            this.btnAsk.Name = "btnAsk";
            this.btnAsk.Size = new System.Drawing.Size(30, 30);
            this.btnAsk.TabIndex = 9;
            this.btnAsk.Text = "?";
            this.btnAsk.UseVisualStyleBackColor = true;
            this.btnAsk.Click += new System.EventHandler(this.btnAsk_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Location = new System.Drawing.Point(460, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 10;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(490, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSelectFile.FlatAppearance.BorderSize = 0;
            this.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile.Location = new System.Drawing.Point(397, 90);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(113, 30);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = false;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnEncryptDecrypt
            // 
            this.btnEncryptDecrypt.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEncryptDecrypt.FlatAppearance.BorderSize = 0;
            this.btnEncryptDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncryptDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncryptDecrypt.Location = new System.Drawing.Point(397, 131);
            this.btnEncryptDecrypt.Name = "btnEncryptDecrypt";
            this.btnEncryptDecrypt.Size = new System.Drawing.Size(113, 30);
            this.btnEncryptDecrypt.TabIndex = 3;
            this.btnEncryptDecrypt.Text = "Encrypt";
            this.btnEncryptDecrypt.UseVisualStyleBackColor = false;
            this.btnEncryptDecrypt.Click += new System.EventHandler(this.btnEncryptDecrypt_Click);
            // 
            // txtFileURL
            // 
            this.txtFileURL.BackColor = System.Drawing.SystemColors.Control;
            this.txtFileURL.Depth = 0;
            this.txtFileURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileURL.Hint = "Enter/Select file path";
            this.txtFileURL.Location = new System.Drawing.Point(3, 3);
            this.txtFileURL.MaxLength = 32767;
            this.txtFileURL.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFileURL.Name = "txtFileURL";
            this.txtFileURL.PasswordChar = '\0';
            this.txtFileURL.SelectedText = "";
            this.txtFileURL.SelectionLength = 0;
            this.txtFileURL.SelectionStart = 0;
            this.txtFileURL.Size = new System.Drawing.Size(370, 23);
            this.txtFileURL.TabIndex = 10;
            this.txtFileURL.TabStop = false;
            this.txtFileURL.UseSystemPasswordChar = false;
            // 
            // txtNewFileName
            // 
            this.txtNewFileName.BackColor = System.Drawing.SystemColors.Control;
            this.txtNewFileName.Depth = 0;
            this.txtNewFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewFileName.Hint = "New file name";
            this.txtNewFileName.Location = new System.Drawing.Point(3, 44);
            this.txtNewFileName.MaxLength = 32767;
            this.txtNewFileName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNewFileName.Name = "txtNewFileName";
            this.txtNewFileName.PasswordChar = '\0';
            this.txtNewFileName.SelectedText = "";
            this.txtNewFileName.SelectionLength = 0;
            this.txtNewFileName.SelectionStart = 0;
            this.txtNewFileName.Size = new System.Drawing.Size(370, 23);
            this.txtNewFileName.TabIndex = 11;
            this.txtNewFileName.TabStop = false;
            this.txtNewFileName.UseSystemPasswordChar = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.Navy;
            this.lblHeader.Location = new System.Drawing.Point(18, 42);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(170, 31);
            this.lblHeader.TabIndex = 14;
            this.lblHeader.Text = "Encrypt File";
            // 
            // lblStatues
            // 
            this.lblStatues.AutoSize = true;
            this.lblStatues.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatues.Location = new System.Drawing.Point(24, 180);
            this.lblStatues.Name = "lblStatues";
            this.lblStatues.Size = new System.Drawing.Size(99, 20);
            this.lblStatues.TabIndex = 15;
            this.lblStatues.Text = "label statues";
            // 
            // radioEncrypt
            // 
            this.radioEncrypt.AutoSize = true;
            this.radioEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioEncrypt.Location = new System.Drawing.Point(334, 49);
            this.radioEncrypt.Name = "radioEncrypt";
            this.radioEncrypt.Size = new System.Drawing.Size(81, 24);
            this.radioEncrypt.TabIndex = 16;
            this.radioEncrypt.TabStop = true;
            this.radioEncrypt.Text = "Encrypt";
            this.radioEncrypt.UseVisualStyleBackColor = true;
            this.radioEncrypt.CheckedChanged += new System.EventHandler(this.radioEncrypt_CheckedChanged);
            // 
            // radioDecrypt
            // 
            this.radioDecrypt.AutoSize = true;
            this.radioDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDecrypt.Location = new System.Drawing.Point(421, 49);
            this.radioDecrypt.Name = "radioDecrypt";
            this.radioDecrypt.Size = new System.Drawing.Size(82, 24);
            this.radioDecrypt.TabIndex = 17;
            this.radioDecrypt.TabStop = true;
            this.radioDecrypt.Text = "Decrypt";
            this.radioDecrypt.UseVisualStyleBackColor = true;
            // 
            // panelEncrypt
            // 
            this.panelEncrypt.Controls.Add(this.txtFileURL);
            this.panelEncrypt.Controls.Add(this.txtNewFileName);
            this.panelEncrypt.Location = new System.Drawing.Point(12, 90);
            this.panelEncrypt.Name = "panelEncrypt";
            this.panelEncrypt.Size = new System.Drawing.Size(379, 80);
            this.panelEncrypt.TabIndex = 18;
            // 
            // panelDecrypt
            // 
            this.panelDecrypt.Controls.Add(this.txtSelectFileURLDecrypt);
            this.panelDecrypt.Controls.Add(this.txtKey);
            this.panelDecrypt.Location = new System.Drawing.Point(12, 90);
            this.panelDecrypt.Name = "panelDecrypt";
            this.panelDecrypt.Size = new System.Drawing.Size(379, 80);
            this.panelDecrypt.TabIndex = 19;
            // 
            // txtSelectFileURLDecrypt
            // 
            this.txtSelectFileURLDecrypt.BackColor = System.Drawing.SystemColors.Control;
            this.txtSelectFileURLDecrypt.Depth = 0;
            this.txtSelectFileURLDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectFileURLDecrypt.Hint = "Enter/Select file path";
            this.txtSelectFileURLDecrypt.Location = new System.Drawing.Point(3, 3);
            this.txtSelectFileURLDecrypt.MaxLength = 32767;
            this.txtSelectFileURLDecrypt.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSelectFileURLDecrypt.Name = "txtSelectFileURLDecrypt";
            this.txtSelectFileURLDecrypt.PasswordChar = '\0';
            this.txtSelectFileURLDecrypt.SelectedText = "";
            this.txtSelectFileURLDecrypt.SelectionLength = 0;
            this.txtSelectFileURLDecrypt.SelectionStart = 0;
            this.txtSelectFileURLDecrypt.Size = new System.Drawing.Size(370, 23);
            this.txtSelectFileURLDecrypt.TabIndex = 10;
            this.txtSelectFileURLDecrypt.TabStop = false;
            this.txtSelectFileURLDecrypt.UseSystemPasswordChar = false;
            // 
            // txtKey
            // 
            this.txtKey.BackColor = System.Drawing.SystemColors.Control;
            this.txtKey.Depth = 0;
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Hint = "Enter Key value";
            this.txtKey.Location = new System.Drawing.Point(3, 44);
            this.txtKey.MaxLength = 32767;
            this.txtKey.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtKey.Name = "txtKey";
            this.txtKey.PasswordChar = '\0';
            this.txtKey.SelectedText = "";
            this.txtKey.SelectionLength = 0;
            this.txtKey.SelectionStart = 0;
            this.txtKey.Size = new System.Drawing.Size(370, 23);
            this.txtKey.TabIndex = 2;
            this.txtKey.TabStop = false;
            this.txtKey.UseSystemPasswordChar = false;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.panelHeader;
            // 
            // EncryptFile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(522, 210);
            this.Controls.Add(this.panelDecrypt);
            this.Controls.Add(this.panelEncrypt);
            this.Controls.Add(this.radioDecrypt);
            this.Controls.Add(this.radioEncrypt);
            this.Controls.Add(this.lblStatues);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnEncryptDecrypt);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EncryptFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encrypt File";
            this.Load += new System.EventHandler(this.EncryptFile_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelEncrypt.ResumeLayout(false);
            this.panelDecrypt.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnEncryptDecrypt;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFileURL;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNewFileName;
        private System.Windows.Forms.Button btnAsk;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblStatues;
        private System.Windows.Forms.RadioButton radioEncrypt;
        private System.Windows.Forms.RadioButton radioDecrypt;
        private System.Windows.Forms.Panel panelEncrypt;
        private System.Windows.Forms.Panel panelDecrypt;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSelectFileURLDecrypt;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtKey;
        private DragControl dragControl1;
    }
}