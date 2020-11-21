using FBAppCore.Login;
using System;
using System.Windows.Forms;

namespace FBAppUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FacebookLoginClient loginClient = new FacebookLoginClient();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ApplicationManager applicationManager = new ApplicationManager(loginClient);

            applicationManager.RunApplication();
        }
    }
}
