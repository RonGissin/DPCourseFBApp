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
        private LoginForm m_LoginForm;
        private ApplicationForm m_ApplicationForm;

        public ApplicationManager(ILoginClient i_loginClient)
        {
            m_loginClient = i_loginClient;
            m_LoginForm = new LoginForm(m_loginClient);
            m_ApplicationForm = new ApplicationForm();
        }

        public void RunApplication()
        {
            LoginFormResult loginFormResult = ShowLoginForm();
            ShowApplicationForm(loginFormResult);
        }

        private LoginFormResult ShowLoginForm()
        {
            DialogResult dialogResult = DialogResult.Retry;

            while (dialogResult == DialogResult.Retry)
            {
                m_LoginForm.Dispose();
                m_LoginForm = new LoginForm(m_loginClient);
                dialogResult = m_LoginForm.ShowDialog();
            }

            LoginFormResult loginFormResult = new LoginFormResult
            {
                DialogResult = m_LoginForm.DialogResult,
                AccessToken = m_LoginForm.AccessToken,
                User = m_LoginForm.User
            };

            m_LoginForm.Dispose();

            return loginFormResult;
        }

        private void ShowApplicationForm(LoginFormResult loginFormResult)
        {
            if (loginFormResult.DialogResult == DialogResult.OK)
            {
                DialogResult dialogResult = m_ApplicationForm.InjectFormDataByUser(loginFormResult.User)
                    .ShowDialog();
            }
        }
    }
}
