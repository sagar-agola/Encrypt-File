using System;
using System.Collections.Generic;

namespace Encrypt_Library
{
    public class BusinessLogic
    {
        public static string Encrypt(string inputString, int key)
        {
            char [] ans = new char [inputString.Length];

            for (int i = 0; i < inputString.Length; i++)
            {
                int temp = GetASCIIValue (inputString [i]);
                temp += (i + key);

                ans [i] = GetCharFromASCII (temp);
            }
            return new string (ans);
        }
        public static string Decrypt(string inputString, int key)
        {
            char [] ans = new char [inputString.Length];

            for (int i = 0; i < inputString.Length; i++)
            {
                int temp = GetASCIIValue (inputString [i]);
                temp -= (i + key);
                if (temp < 300 && temp > 0)
                    ans [i] = GetCharFromASCII (temp);
            }

            return new string (ans);
        }
        private static char GetCharFromASCII(int ch) => Convert.ToChar (ch);
        private static int GetASCIIValue(char ch) => Convert.ToInt32 (ch);
        //private static List<byte> GetBinary(int input)
        //{
        //    List<byte> byteList = new List<byte> ();
        //    int [] intArr = GetIntArray (input);
        //    foreach(int digit in intArr)
        //    {
        //        switch (digit)
        //        {
        //            case 0:
        //                byteList.Add (0);
        //                byteList.Add (0);
        //                byteList.Add (0);
        //                byteList.Add (0);
        //                break;
        //            case 1:
        //                byteList.Add (0);
        //                byteList.Add (0);
        //                byteList.Add (0);
        //                byteList.Add (1);
        //                break;
        //            case 2:
        //                byteList.Add (0);
        //                byteList.Add (0);
        //                byteList.Add (1);
        //                byteList.Add (0);
        //                break;
        //            case 3:
        //                byteList.Add (0);
        //                byteList.Add (0);
        //                byteList.Add (1);
        //                byteList.Add (1);
        //                break;
        //            case 4:
        //                byteList.Add (0);
        //                byteList.Add (1);
        //                byteList.Add (0);
        //                byteList.Add (0);
        //                break;
        //            case 5:
        //                byteList.Add (0);
        //                byteList.Add (1);
        //                byteList.Add (0);
        //                byteList.Add (1);
        //                break;
        //            case 6:
        //                byteList.Add (0);
        //                byteList.Add (1);
        //                byteList.Add (1);
        //                byteList.Add (0);
        //                break;
        //            case 7:
        //                byteList.Add (0);
        //                byteList.Add (1);
        //                byteList.Add (1);
        //                byteList.Add (1);
        //                break;
        //            case 8:
        //                byteList.Add (1);
        //                byteList.Add (0);
        //                byteList.Add (0);
        //                byteList.Add (0);
        //                break;
        //            case 9:
        //                byteList.Add (1);
        //                byteList.Add (0);
        //                byteList.Add (0);
        //                byteList.Add (1);
        //                break;
        //            default:
        //                break;
        //        }
        //    }
        //    return byteList;
        //}
        //private static int [] GetIntArray(int num)
        //{
        //    List<int> listOfInts = new List<int> ();
        //    while (num > 0)
        //    {
        //        listOfInts.Add (num % 10);
        //        num = num / 10;
        //    }
        //    listOfInts.Reverse ();
        //    return listOfInts.ToArray ();
        //}
        //public static List<byte> Encrypt(string inputString, int key)
        //{
        //    char [] ans = new char [inputString.Length];
        //    List<byte> ansByteList = new List<byte> ();
        //    for (int i = 0; i < inputString.Length; i++)
        //    {
        //        int temp = GetASCIIValue (inputString [i]);
        //        temp += (i + key);

        //        ansByteList = GetBinary (temp);
        //        //ans [i] = GetCharFromASCII (temp);
        //    }
        //    return ansByteList;
        //}
    }
}
