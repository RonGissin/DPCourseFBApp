using System;
using FacebookWrapper.ObjectModel;

namespace FBAppCore.UserMatching
{
    internal interface IUserMatcher
    {
        User FindMatch(User i_UserToMatchTo, Func<User, bool> i_FilterFunc);
    }
}
