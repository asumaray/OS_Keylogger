/*
 *  formRegister.cs
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
    public partial class formRegister : Form
    {
        public formRegister()
        {
            InitializeComponent();
        }

        /**
         * First registration key textbox
         **/
        private void txtKey1_TextChanged(object sender, EventArgs e)
        {
            if (txtKey1.Text.Length >= 4)
            {
                string text = parseForDashes(txtKey1.Text);
                if (text.Length >= 4)
                {
                    string first = text.Substring(0, 4);
                    string second = text.Substring(4);
                    txtKey1.Text = first;
                    txtKey2.Text = second;
                    txtKey2.Focus();
                }
            }
        }

        /**
         * Second registration key textbox
         **/
        private void txtKey2_TextChanged(object sender, EventArgs e)
        {
            if (txtKey2.Text.Length >= 5)
            {
                string text = parseForDashes(txtKey2.Text);
                if (text.Length >= 5)
                {
                    string first = text.Substring(0, 5);
                    string second = text.Substring(5);
                    txtKey2.Text = first;
                    txtKey3.Text = second;
                    txtKey3.Focus();
                }
            }

        }

        /**
         * Third registration key textbox
         **/
        private void txtKey3_TextChanged(object sender, EventArgs e)
        {
            if (txtKey3.Text.Length >= 5)
            {
                string text = parseForDashes(txtKey3.Text);
                if (text.Length >= 5)
                {
                    string first = text.Substring(0, 5);
                    string second = text.Substring(5);
                    txtKey3.Text = first;
                    txtKey4.Text = second;
                    txtKey4.Focus();
                }
            }
        }

        /**
         * Fourth registration key textbox
         **/
        private void txtKey4_TextChanged(object sender, EventArgs e)
        {
            if (txtKey4.Text.Length >= 5)
            {
                string text = parseForDashes(txtKey4.Text);
                if (text.Length >= 5)
                {
                    string first = text.Substring(0, 5);
                    string second = text.Substring(5);
                    txtKey4.Text = first;
                    txtKey5.Text = second;
                    txtKey5.Focus();
                }
            }
        }

        /**
         * Fifth registration key textbox
         **/
        private void txtKey5_TextChanged(object sender, EventArgs e)
        {
            if (txtKey5.Text.Length >= 5)
            {
                string text = parseForDashes(txtKey5.Text);
                if (text.Length >= 5)
                {
                    txtKey5.Text = text.Substring(0, 5);
                }
            }
        }

        /**
         * Remove any dashes in the passed string
         **/
        private string parseForDashes(string s)
        {
            int indexOfDash = s.IndexOf('-');
            if (indexOfDash > 0)
            {
                string toReturn = s.Substring(0, indexOfDash);
                toReturn += s.Substring(indexOfDash + 1);
                return parseForDashes(toReturn);
            }
            return s;
        }

        /**
         * Set 'registered' registry value to valse when registration is canceled
         **/
        private void txtCancel_Click(object sender, EventArgs e)
        {
            RegistryAccess.SetStringRegistryValue("registered", "false");
            this.Close();
        }

        /**
         * Check to see if registration key is correct and then store in registry
         **/
        static string GetMd5Hash(MD5 md5Hash, string input)
        {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                StringBuilder sBuilder = new StringBuilder();

                for(int i=0;i<data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("X2"));
                }

                return sBuilder.ToString();
            }
            static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
            {
                string hashOfInput = GetMd5Hash(md5Hash, input);

                StringComparer comparer = StringComparer.OrdinalIgnoreCase;

                if (0==comparer.Compare(hashOfInput, hash))
                {
                    return true;
                }
                else
                {
                    return false;
                }  
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

        private void txtContinue_Click(object sender, EventArgs e)
        {
            
            string enteredKey = txtKey1.Text + txtKey2.Text + txtKey3.Text
                + txtKey4.Text + txtKey5.Text;
            string seed = txtKey1.Text;
            enteredKey = parseForDashes(enteredKey);
            string hash = CalculateMD5Hash(seed);
            hash = hash.Remove(20);
            //txtName.Text = hash;    //uncomment for development testing
            if (enteredKey.Equals(seed+hash))
            {
                RegistryAccess.SetStringRegistryValue("registered", "true");
                RegistryAccess.SetStringRegistryValue("serial", enteredKey);
                if (txtName != null)
                {
                    RegistryAccess.SetStringRegistryValue("name", txtName.Text);
                }
                MessageBox.Show("Your product has been registered, please restart The Logger"
                    + " to complete registration.", "Thank you", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("The registration key you entered is incorrect, please"
                    + " look over the key and try again.", "Sorry", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        
           

            
    }
}
