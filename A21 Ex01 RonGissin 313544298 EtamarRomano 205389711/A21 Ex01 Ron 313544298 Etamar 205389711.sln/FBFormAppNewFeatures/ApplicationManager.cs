using FacebookWrapper;
using FBAppCore.AppSettings;
using FBAppCore.Login;
using FBAppInfra.Validation;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FBFormAppNewFeatures
{
    public class ApplicationManager
    {
        private ILoginClient m_loginClient;
        private LoginForm m_LoginForm;
        private ApplicationForm m_ApplicationForm;
        private bool m_ExitSignal;
        private AppSettings m_AppSettings;

        public ApplicationManager(ILoginClient i_loginClient)
        {
            m_loginClient = InputGuard.CheckNullArgument(i_loginClient, nameof(i_loginClient));
            m_ExitSignal = false;

            try
            {
                m_AppSettings = AppXmlSettingsHandler.Instance.LoadSettingsFromFile();
            }
            catch (Exception exception)
            {
                UseDefaultSettings();
            }

        }

        public void RunApplication()
        {
            while (!m_ExitSignal)
            {
                LoginResultData LoginResultData = m_AppSettings.RememberUser && !string.IsNullOrEmpty(m_AppSettings.LastAccessToken) ?
                    ConnectWithLastUser() :
                    ShowLoginForm();
                DialogResult appDialogResult = ShowApplicationForm(LoginResultData);
                m_ExitSignal = appDialogResult == DialogResult.Cancel;
            }
        }

        private LoginResultData ConnectWithLastUser()
        {
            LoginResult loginResult = m_loginClient.Connect(m_AppSettings.LastAccessToken);

            return new LoginResultData
            {
                LoginDialogResult = DialogResult.OK,
                AccessToken = loginResult.AccessToken,
                User = loginResult.LoggedInUser
            };
        }

        private void UseDefaultSettings()
        {
            m_AppSettings = new AppSettings()
            {
                LastWindowSize = new Size(900, 700),
                LastAccessToken = string.Empty,
                RememberUser = false
            };
        }

        private LoginResultData ShowLoginForm()
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

        private DialogResult ShowApplicationForm(LoginResultData loginFormResult)
        {
            DialogResult dialogResult = DialogResult.OK;

            if (loginFormResult.LoginDialogResult == DialogResult.OK)
            {
                m_ApplicationForm = new ApplicationForm(loginFormResult, m_AppSettings);
                dialogResult = m_ApplicationForm.ShowDialog();
                m_ApplicationForm.Dispose();
            }

            return dialogResult;
        }
    }
}
