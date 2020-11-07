using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBFormAppNewFeatures
{
    public class ApplicationManager
    {
        private ILoginClient m_loginClient;

        public ApplicationManager(ILoginClient i_loginClient)
        {
            m_loginClient = i_loginClient;
        }

        public void RunApplication()
        {
            DialogResult loginFormResult = DialogResult.Retry;
            LoginForm loginForm = new LoginForm(m_loginClient);

            while (loginFormResult == DialogResult.Retry)
            {
                loginForm.Dispose();
                loginForm = new LoginForm(m_loginClient);
                loginFormResult = loginForm.ShowDialog();
            }

            if (loginFormResult == DialogResult.OK)
            {
                User loggedInUser = loginForm.User;
                string accessToken = loginForm.AccessToken;
                loginForm.Dispose();
                new ApplicationForm(loggedInUser, accessToken).ShowDialog();
            }
        }
    }
}
