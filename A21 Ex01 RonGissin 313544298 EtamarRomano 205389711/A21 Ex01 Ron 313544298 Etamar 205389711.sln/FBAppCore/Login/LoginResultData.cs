using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FBAppCore.Login
{
    public class LoginResultData
    {
        public DialogResult LoginDialogResult { get; set; }

        public User User { get; set; }

        public string AccessToken { get; set; }
    }
}
