/*
 *  formSplash.cs
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
using System.Threading;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace OS_Keylogger
{
    public partial class formSplash : Form
    {
        // Threading
        static formSplash frmSplash = null;
        static Thread splashThread = null;

        public formSplash()
        {
            InitializeComponent();
        }

        static private void ShowForm()
        {
            frmSplash = new formSplash();
            Application.Run(frmSplash);
        }

        static public void CloseForm()
        {
            frmSplash.Invoke(new EventHandler(frmSplash.KillMe));
            splashThread = null;
            frmSplash = null;
        }

        public void KillMe(object o, EventArgs e)
        {
            this.Close();
        }

        private void formSplash_DoubleClick(object sender, EventArgs e)
        {
            CloseForm();
        }

        static public void ShowSplashScreen()
        {
            if (frmSplash != null)
            {
                return;
            }
            splashThread = new Thread(new ThreadStart(formSplash.ShowForm));
            splashThread.IsBackground = true;
            splashThread.SetApartmentState(ApartmentState.STA);
            splashThread.Start();
        }

        private void formSplash_Load(object sender, EventArgs e)
        {
            string registered = RegistryAccess.GetStringRegistryValue("registered", null);
            if (registered.Equals("false"))
            {
                lblRegistered.Show();
            }
            else
            {
                lblRegistered.Visible = false;
            }
        }
    }

    public class RegistryAccess
    {
        //private const string SOFTWARE_KEY = "";
        private const string COMPANY_NAME = "OS_Program";
        private const string APPLICATION_NAME = "The Logger";
        // Method for retrieving a Registry Value.

        static public string GetStringRegistryValue(string key,
          string defaultValue)
        {
            RegistryKey rkCompany;
            RegistryKey rkApplication;
            rkCompany = Registry.CurrentUser
                                .OpenSubKey("Software", false)
                                .OpenSubKey(COMPANY_NAME, false);
            if (rkCompany != null)
            {
                rkApplication = rkCompany.OpenSubKey(APPLICATION_NAME, true);
                if (rkApplication != null)
                {
                    foreach (string sKey in rkApplication.GetValueNames())
                    {
                        if (sKey == key)
                        {
                            return (string)rkApplication.GetValue(sKey);
                        }
                    }
                }
            }
            return defaultValue;
        }
        // Method for storing a Registry Value.

        static public void SetStringRegistryValue(string key, string stringValue)
        {
            RegistryKey rkSoftware;
            RegistryKey rkCompany;
            RegistryKey rkApplication;
            rkSoftware = Registry.CurrentUser.OpenSubKey("Software", true);
            rkCompany = rkSoftware.CreateSubKey(COMPANY_NAME);
            if (rkCompany != null)
            {
                rkApplication = rkCompany.CreateSubKey(APPLICATION_NAME);
                if (rkApplication != null)
                {
                    rkApplication.SetValue(key, stringValue);
                }
            }
        }
    }
}
