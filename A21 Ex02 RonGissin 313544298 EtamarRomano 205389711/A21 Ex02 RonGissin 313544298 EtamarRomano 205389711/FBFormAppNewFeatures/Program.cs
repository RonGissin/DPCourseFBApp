using System;
using System.Windows.Forms;
using FBAppCore.Login;

namespace FBAppUI
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            FacebookLoginClient loginClient = new FacebookLoginClient();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ApplicationFlowManager applicationManager = new ApplicationFlowManager(loginClient);

            applicationManager.RunApplication();
        }
    }
}
