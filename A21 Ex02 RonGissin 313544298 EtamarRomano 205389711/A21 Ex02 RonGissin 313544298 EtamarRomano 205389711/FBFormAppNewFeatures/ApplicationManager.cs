using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper;
using FBAppCore.AppSettings;
using FBAppCore.Login;
using FBAppCore.Validation;
using FBAppUI.Forms;

namespace FBAppUI
{
    public class ApplicationManager
    {
        private ILoginClient m_loginClient;
        private LoginForm m_LoginForm;
        private ApplicationForm m_ApplicationForm;
        private bool m_ExitSignal;
        private AppSettings m_AppSettings;

        public ApplicationManager(ILoginClient i_LoginClient)
        {
            m_loginClient = InputGuard.CheckNullArgument(i_LoginClient, nameof(i_LoginClient));
            m_ExitSignal = false;

            try
            {
                m_AppSettings = AppXmlSettingsHandler.Instance.LoadSettingsFromFile();
            }
            catch 
            {
                useDefaultSettings();
            }
        }

        public void RunApplication()
        {
            while (!m_ExitSignal)
            {
                LoginResultData LoginResultData = m_AppSettings.RememberUser && !string.IsNullOrEmpty(m_AppSettings.LastAccessToken) ?
                    connectWithLastUser() :
                    showLoginForm();
                DialogResult appDialogResult = showApplicationForm(LoginResultData);
                m_ExitSignal = appDialogResult == DialogResult.Cancel || LoginResultData.LoginDialogResult == DialogResult.Cancel;
            }
        }

        private LoginResultData connectWithLastUser()
        {
            LoginResult loginResult = m_loginClient.Connect(m_AppSettings.LastAccessToken);

            return new LoginResultData
            {
                LoginDialogResult = DialogResult.OK,
                AccessToken = loginResult.AccessToken,
                User = loginResult.LoggedInUser
            };
        }

        private void useDefaultSettings()
        {
            m_AppSettings = new AppSettings()
            {
                LastWindowSize = new Size(900, 700),
                LastAccessToken = string.Empty,
                RememberUser = false
            };
        }

        private LoginResultData showLoginForm()
        {
            DialogResult dialogResult = DialogResult.Retry;

            while (dialogResult == DialogResult.Retry)
            {
                m_LoginForm = new LoginForm(m_loginClient);
                dialogResult = m_LoginForm.ShowDialog();
                m_LoginForm.Dispose();
            }

            LoginResultData loginResultData = new LoginResultData
            {
                LoginDialogResult = m_LoginForm.DialogResult,
                AccessToken = m_LoginForm.AccessToken,
                User = m_LoginForm.User
            };

            return loginResultData;
        }

        private DialogResult showApplicationForm(LoginResultData i_LoginFormResult)
        {
            DialogResult dialogResult = DialogResult.OK;

            if (i_LoginFormResult.LoginDialogResult == DialogResult.OK)
            {
                m_ApplicationForm = new ApplicationForm(i_LoginFormResult, m_AppSettings);
                dialogResult = m_ApplicationForm.ShowDialog();
                m_ApplicationForm.Dispose();
            }

            return dialogResult;
        }
    }
}
