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
        private bool m_ExitSignal;

        public ApplicationManager(ILoginClient i_loginClient)
        {
            m_loginClient = InputGuard.CheckNullArgument(i_loginClient, nameof(i_loginClient));
            m_ExitSignal = false;
        }

        public void RunApplication()
        {
            while (!m_ExitSignal)
            {
                LoginFormResult loginFormResult = ShowLoginForm();
                DialogResult appDialogResult = ShowApplicationForm(loginFormResult);
                m_ExitSignal = appDialogResult == DialogResult.Cancel;
            }
        }

        private LoginFormResult ShowLoginForm()
        {
            DialogResult dialogResult = DialogResult.Retry;

            while (dialogResult == DialogResult.Retry)
            {
                m_LoginForm = new LoginForm(m_loginClient);
                dialogResult = m_LoginForm.ShowDialog();
                m_LoginForm.Dispose();
            }

            LoginFormResult loginFormResult = new LoginFormResult
            {
                DialogResult = m_LoginForm.DialogResult,
                AccessToken = m_LoginForm.AccessToken,
                User = m_LoginForm.User
            };

            return loginFormResult;
        }

        private DialogResult ShowApplicationForm(LoginFormResult loginFormResult)
        {
            DialogResult dialogResult = DialogResult.OK;

            if (loginFormResult.DialogResult == DialogResult.OK)
            {
                m_ApplicationForm = new ApplicationForm(loginFormResult.User);
                dialogResult = m_ApplicationForm.ShowDialog();
                m_ApplicationForm.Dispose();
            }

            return dialogResult;
        }
    }
}
