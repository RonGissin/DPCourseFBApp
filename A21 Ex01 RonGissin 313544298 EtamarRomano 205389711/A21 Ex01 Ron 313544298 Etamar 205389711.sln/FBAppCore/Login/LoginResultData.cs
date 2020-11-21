using FacebookWrapper.ObjectModel;
using System.Windows.Forms;

namespace FBAppCore.Login
{
    public class LoginResultData
    {
        public DialogResult LoginDialogResult { get; set; }

        public User User { get; set; }

        public string AccessToken { get; set; }
    }
}
