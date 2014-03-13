/*
 *  formOptions.cs
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
using System.Runtime.InteropServices;

namespace OS_Keylogger
{
    public partial class formOptions : Form
    {
        public formOptions()
        {
            InitializeComponent();
        }

        /**
         * Close the window.
         **/
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
         * Establish the correct values for widgets on the form.
         **/
        private void formOptions_Load(object sender, EventArgs e)
        {
            txtHotkey.Text = OS_Keylogger.Properties.Settings.Default.hotkey.ToString();
            txtInterval.Text = OS_Keylogger.Properties.Settings.Default.screenInterval.ToString();
            txtScreenDirectory.Text = OS_Keylogger.Properties.Settings.Default.screenDirectory;
            if (OS_Keylogger.Properties.Settings.Default.textMode)
            {
                chkText.Checked = true;
            }

            switch (OS_Keylogger.Properties.Settings.Default.logDelimeter)
            {
                case " ":
                    cmboDelimiter.SelectedItem = "Space";
                    break;

                case "\n":
                    cmboDelimiter.SelectedItem = "New Line";
                    break;

                case ", ":
                    cmboDelimiter.SelectedItem = "Comma";
                    break;

                default:
                    cmboDelimiter.SelectedItem = "None";
                    break;
            }

            if (OS_Keylogger.Properties.Settings.Default.capitalize)
            {
                rdioUppercase.Select();
            } 
            else
            {
                rdioLowercase.Select();
            }

            if (OS_Keylogger.Properties.Settings.Default.screenCap)
            {
                chkScreenCap.Checked = true;
                txtScreenDirectory.Enabled = true;
                txtInterval.Enabled = true;
            }
            else
            {
                chkScreenCap.Checked = false;
                txtScreenDirectory.Enabled = false;
                txtInterval.Enabled = false;
            }

            string isRegistered = RegistryAccess.GetStringRegistryValue("registered", null);
            if (isRegistered == "false")
            {
                grpScrenCap.Enabled = false;
                lblHotkey.Enabled = false;
                txtHotkey.Enabled = false;
            }
        }

        /**
         * Save all values from widgets to settings.
         **/
        private void btnSave_Click(object sender, EventArgs e)
        {
            OS_Keylogger.Properties.Settings.Default.textMode = chkText.Checked;
            OS_Keylogger.Properties.Settings.Default.capitalize = rdioUppercase.Checked;
            OS_Keylogger.Properties.Settings.Default.hotkey = Int32.Parse(txtHotkey.Text);
            OS_Keylogger.Properties.Settings.Default.screenInterval = Int32.Parse(txtInterval.Text);
            OS_Keylogger.Properties.Settings.Default.screenCap = chkScreenCap.Checked;
            OS_Keylogger.Properties.Settings.Default.screenDirectory = txtScreenDirectory.Text;
            switch (cmboDelimiter.SelectedItem.ToString())
            {
                case "Space":
                    OS_Keylogger.Properties.Settings.Default.logDelimeter = " ";
                    break;
                case "New Line":
                    OS_Keylogger.Properties.Settings.Default.logDelimeter = "\r\n";
                    break;
                case "Comma":
                    OS_Keylogger.Properties.Settings.Default.logDelimeter = ", ";
                    break;
                case "None":
                    OS_Keylogger.Properties.Settings.Default.logDelimeter = "";
                    break;
            }
            this.Close();
        }

        /**
         * Restore widget values to default.
         **/
        private void btnDefault_Click(object sender, EventArgs e)
        {
            chkText.Checked = false;
            cmboDelimiter.SelectedItem = "None";
            rdioUppercase.Select();
        }

        /**
         * When text mode is enabled there must be no delimiter, so
         * make sure the delimiter is set to 'None' and the combo box
         * is disabled when text mode is checked.
         **/
        private void chkText_CheckedChanged(object sender, EventArgs e)
        {
            if (chkText.Checked)
            {
                cmboDelimiter.SelectedItem = "None";
                cmboDelimiter.Enabled = false;
            }
            else
            {
                cmboDelimiter.Enabled = true;
            }
        }

        /**
         * Click the textbox to create a hotkey for stealth mode
         **/
        private void txtHotkey_Click(object sender, EventArgs e)
        {
            txtHotkey.Text = "Press a key.";
            Keyhook.CreateHook(hotkeyParser);
        }

        /**
         * Parse the hotkey
         **/
        private void hotkeyParser(IntPtr wParam, IntPtr lParam)
        {
            int inKey = Marshal.ReadInt32(lParam);
            Keyhook.Key key = new Keyhook.Key();
            key = (Keyhook.Key)inKey;

            if (key == Keyhook.Key.VK_0)

                txtHotkey.Text = "0";

            if (key == Keyhook.Key.VK_1)

                txtHotkey.Text = "1";

            if (key == Keyhook.Key.VK_2)

                txtHotkey.Text = "2";

            if (key == Keyhook.Key.VK_3)

                txtHotkey.Text = "3";

            if (key == Keyhook.Key.VK_4)

                txtHotkey.Text = "4";

            if (key == Keyhook.Key.VK_5)

                txtHotkey.Text = "5";

            if (key == Keyhook.Key.VK_6)

                txtHotkey.Text = "6";

            if (key == Keyhook.Key.VK_7)

                txtHotkey.Text = "7";

            if (key == Keyhook.Key.VK_8)

                txtHotkey.Text = "8";

            if (key == Keyhook.Key.VK_9)

                txtHotkey.Text = "9";

            if (key == Keyhook.Key.VK_A)

                txtHotkey.Text = "A";

            if (key == Keyhook.Key.VK_B)

                txtHotkey.Text = "B";

            if (key == Keyhook.Key.VK_C)

                txtHotkey.Text = "C";

            if (key == Keyhook.Key.VK_D)

                txtHotkey.Text = "D";

            if (key == Keyhook.Key.VK_E)

                txtHotkey.Text = "E";

            if (key == Keyhook.Key.VK_F)

                txtHotkey.Text = "F";

            if (key == Keyhook.Key.VK_G)

                txtHotkey.Text = "G";

            if (key == Keyhook.Key.VK_H)

                txtHotkey.Text = "H";

            if (key == Keyhook.Key.VK_I)

                txtHotkey.Text = "I";

            if (key == Keyhook.Key.VK_J)

                txtHotkey.Text = "J";

            if (key == Keyhook.Key.VK_K)

                txtHotkey.Text = "K";

            if (key == Keyhook.Key.VK_L)

                txtHotkey.Text = "L";

            if (key == Keyhook.Key.VK_M)

                txtHotkey.Text = "M";

            if (key == Keyhook.Key.VK_N)

                txtHotkey.Text = "N";

            if (key == Keyhook.Key.VK_O)

                txtHotkey.Text = "O";

            if (key == Keyhook.Key.VK_P)

                txtHotkey.Text = "P";

            if (key == Keyhook.Key.VK_Q)

                txtHotkey.Text = "Q";

            if (key == Keyhook.Key.VK_R)

                txtHotkey.Text = "R";

            if (key == Keyhook.Key.VK_S)

                txtHotkey.Text = "S";

            if (key == Keyhook.Key.VK_T)

                txtHotkey.Text = "T";

            if (key == Keyhook.Key.VK_U)

                txtHotkey.Text = "U";

            if (key == Keyhook.Key.VK_V)

                txtHotkey.Text = "V";

            if (key == Keyhook.Key.VK_W)

                txtHotkey.Text = "W";

            if (key == Keyhook.Key.VK_X)

                txtHotkey.Text = "X";

            if (key == Keyhook.Key.VK_Y)

                txtHotkey.Text = "Y";

            if (key == Keyhook.Key.VK_Z)

                txtHotkey.Text = "Z";

            if (key == Keyhook.Key.VK_NUMPAD0)

                txtHotkey.Text = "0";

            if (key == Keyhook.Key.VK_NUMPAD1)

                txtHotkey.Text = "1";

            if (key == Keyhook.Key.VK_NUMPAD2)

                txtHotkey.Text = "2";

            if (key == Keyhook.Key.VK_NUMPAD3)

                txtHotkey.Text = "3";

            if (key == Keyhook.Key.VK_NUMPAD4)

                txtHotkey.Text = "4";

            if (key == Keyhook.Key.VK_NUMPAD5)

                txtHotkey.Text = "5";

            if (key == Keyhook.Key.VK_NUMPAD6)

                txtHotkey.Text = "6";

            if (key == Keyhook.Key.VK_NUMPAD7)

                txtHotkey.Text = "7";

            if (key == Keyhook.Key.VK_NUMPAD8)

                txtHotkey.Text = "8";

            if (key == Keyhook.Key.VK_NUMPAD9)

                txtHotkey.Text = "9";

            if (key == Keyhook.Key.VK_BACK)

                txtHotkey.Text = "[BACK]";

            if (key == Keyhook.Key.VK_TAB)

                txtHotkey.Text = "[TAB]";

            if (key == Keyhook.Key.VK_RETURN)

                txtHotkey.Text = "[RETURN]";

            if (key == Keyhook.Key.VK_SHIFT)

                txtHotkey.Text = "[SHIFT]";

            if (key == Keyhook.Key.VK_CONTROL)

                txtHotkey.Text = "[CTRL]";

            if (key == Keyhook.Key.VK_MENU)

                txtHotkey.Text = "[ALT]";

            if (key == Keyhook.Key.VK_CAPITAL)

                txtHotkey.Text = "[CAPITAL]";

            if (key == Keyhook.Key.VK_ESCAPE)

                txtHotkey.Text = "[ESC]";

            if (key == Keyhook.Key.VK_SPACE)

                txtHotkey.Text = "[SPACE]";

            if (key == Keyhook.Key.VK_UP)

                txtHotkey.Text = "[UP]";

            if (key == Keyhook.Key.VK_RIGHT)

                txtHotkey.Text = "[RIGHT]";

            if (key == Keyhook.Key.VK_DOWN)

                txtHotkey.Text = "[DOWN]";

            if (key == Keyhook.Key.VK_LEFT)

                txtHotkey.Text = "[LEFT]";

            if (key == Keyhook.Key.VK_DELETE)

                txtHotkey.Text = "[DEL]";

            if (key == Keyhook.Key.VK_LWIN)

                txtHotkey.Text = "[WINDOWS]";

            if (key == Keyhook.Key.VK_RWIN)

                txtHotkey.Text = "[WINDOWS]";

            if (key == Keyhook.Key.VK_LSHIFT)

                txtHotkey.Text = "[SHIFT]";

            if (key == Keyhook.Key.VK_RSHIFT)

                txtHotkey.Text = "[SHIFT]";

            if (key == Keyhook.Key.VK_LCONTROL)

                txtHotkey.Text = "[CTRL]";

            if (key == Keyhook.Key.VK_RCONTROL)

                txtHotkey.Text = "[CTRL]";

            if (key == Keyhook.Key.VK_LMENU)

                txtHotkey.Text = "[ALT]";

            if (key == Keyhook.Key.VK_RMENU)

                txtHotkey.Text = "[ALT]";

            if (key == Keyhook.Key.VK_OEM_1)

                txtHotkey.Text = ";";

            if (key == Keyhook.Key.VK_OEM_PLUS)

                txtHotkey.Text = "=";

            if (key == Keyhook.Key.VK_OEM_COMMA)

                txtHotkey.Text = ",";

            if (key == Keyhook.Key.VK_OEM_MINUS)

                txtHotkey.Text = "-";

            if (key == Keyhook.Key.VK_OEM_PERIOD)

                txtHotkey.Text = ".";

            if (key == Keyhook.Key.VK_OEM_2)

                txtHotkey.Text = "/";

            if (key == Keyhook.Key.VK_OEM_3)

                txtHotkey.Text = "`";

            if (key == Keyhook.Key.VK_OEM_4)

                txtHotkey.Text = "[";

            if (key == Keyhook.Key.VK_OEM_5)

                txtHotkey.Text = "\\";

            if (key == Keyhook.Key.VK_OEM_6)

                txtHotkey.Text = "]";

            if (key == Keyhook.Key.VK_OEM_7)

                txtHotkey.Text = "'";

            //txtHotkey.Text = hotkey.ToString();
            //txtHotkey.Text = inKey.ToString();
            Keyhook.DestroyHook();
        }

        /**
         * Display a dialog to choose the directory to save screencaps
         **/
        private void btnBrowseScreenDirectory_Click(object sender, EventArgs e)
        {
            DialogResult result = dialogScreenFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                string capDirectory = dialogScreenFolder.SelectedPath;
                txtScreenDirectory.Text = capDirectory;
            }
        }

        /**
         * If screencaps are enabled, enable changing the directory and interval
         **/
        private void chkScreenCap_CheckedChanged(object sender, EventArgs e)
        {
            if (chkScreenCap.Checked)
            {
                txtScreenDirectory.Enabled = true;
                txtInterval.Enabled = true;
            }
            else
            {
                txtScreenDirectory.Enabled = false;
                txtInterval.Enabled = false;
            }
        }
    }
}
