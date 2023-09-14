using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
namespace code_Breakers
{
    public partial class Form1 : Form
    {
        private static readonly char[] ADFGX = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', ' ', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        private static readonly string[] ADFGXTable = {
    "AA", "AD", "AF", "AG", "AX", "DA", "DD", "DF", "DG", "DG",
    "DX", "FA", "FD", "FF", "FG", "FX", "GA", "GD", "GF", "GG",
    "GX", "XA", "XD", "XF", "XG", "XX", " " , "AA", "AD", "AF",
    "AG", "AX", "DA", "DD", "DF", "DG", "DG", "DX", "FA", "FD",
    "FF", "FG", "FX", "GA", "GD", "GF", "GG", "GX", "XA", "XD",
    "XF", "XG", "XX"
};

        private ADFGXCipher cipher;

        public Form1()
        {
            InitializeComponent();
            cipher = new ADFGXCipher();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            string plaintext = inputTextBox.Text.ToUpper();
            string encryptedText = EncryptADFGX(plaintext);
            outputTextBox.Text = encryptedText; // Update outputTextBox

            // Add debugging statements
            Console.WriteLine($"Input: {plaintext}");
            Console.WriteLine($"Encrypted: {encryptedText}");
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string encryptedText = inputTextBox.Text.ToUpper();
            string decryptedText = DecryptADFGX(encryptedText);
            outputTextBox.Text = decryptedText; // Update outputTextBox

            // Add debugging statements
            Console.WriteLine($"Input: {encryptedText}");
            Console.WriteLine($"Decrypted: {decryptedText}");
        }
        private string EncryptADFGX(string plaintext)
        {
            List<string> adfgxList = new List<string>();

            foreach (char c in plaintext)
            {
                int index = Array.IndexOf(ADFGX, c);
                if (index != -1)
                {
                    int row = index / 5;
                    int col = index % 5;
                    adfgxList.Add(ADFGXTable[row * 5 + col]);
                }
            }

            // Apply transposition (e.g., rearrange columns and rows here).

            return string.Join("", adfgxList);
        }



        private string DecryptADFGX(string encryptedText)
        {
            List<char> adfgxList = new List<char>();

            int i;
            for (i = 0; i < encryptedText.Length - 1; i += 2)
            {
                string pair = encryptedText.Substring(i, 2);
                int index = Array.IndexOf(ADFGXTable, pair);
                if (index != -1)
                {
                    adfgxList.Add(ADFGX[index]);
                }
            }

            // Handle the last character if the input length is odd.
            if (i < encryptedText.Length)
            {
                // Handle the last character here (e.g., append it to the end).
                char lastCharacter = encryptedText[i];
                // You can choose to append it to the result or handle it differently.
                // For example, adfgxList.Add(lastCharacter) to append it to the result.
            }

            return new string(adfgxList.ToArray());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}