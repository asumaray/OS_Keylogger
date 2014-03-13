using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OS_Keylogger
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            formSplash.ShowSplashScreen();
            System.Threading.Thread.Sleep(5000);
            formSplash.CloseForm();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formMain());
        }
    }
}
