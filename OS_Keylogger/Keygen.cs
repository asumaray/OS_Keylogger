/*
 *  Keygen.cs
 *  
 *  Audie Sumaray
 *  Eric Hacecky
 *  
 *  12/3/11
 *  
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace OS_Keylogger
{
    public partial class Keygen : Form
    {
        public Keygen()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 4;

        }

        public string CalculateMD5Hash(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            string seed = textBox1.Text;
            string hash = CalculateMD5Hash(seed);
            hash = hash.Remove(20);
            textBox2.Text = seed + hash;
        }
    }
}
