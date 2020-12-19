using FacebookWrapper.ObjectModel;
using FBAppCore.Login;
using FBAppInfra.Validation;
using System;

namespace FBAppCore
{
    // TODO: Understand if this is plausible to implement.
    public class ApplicationFacade
    {
        public User AlbumUser { get; set; }

        private IUserMatcher m_UserMatcher;
        private User m_LoggedInUser;
        private ILoginClient m_LoginClient;

        public ApplicationFacade(
            User i_LoggedInUser)
        {
            m_LoggedInUser = InputGuard.CheckNullArgument(i_LoggedInUser, nameof(i_LoggedInUser));
            m_UserMatcher = new UserMatcher();
        }

        public User FindBestMatch(User i_UserToMatchTo, Func<User, bool> i_FilterFunc)
        {
            return m_UserMatcher.FindMatch(i_UserToMatchTo, i_FilterFunc);
        }

        public void FetchUserAlbums()
        {

        }
    }
}
