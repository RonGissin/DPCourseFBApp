using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FBAppCore.UserMatching
{
    internal interface IUserMatcher
    {
        User FindMatch(User i_UserToMatchTo, Func<User, bool> i_FilterFunc);
    }
}
