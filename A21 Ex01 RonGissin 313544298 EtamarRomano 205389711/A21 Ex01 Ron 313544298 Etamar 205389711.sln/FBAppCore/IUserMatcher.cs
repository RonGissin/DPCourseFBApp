using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBAppCore
{
    public interface IUserMatcher
    {
        User FindMatch(User i_UserToMatchTo, Func<User, bool> i_FilterFunc);
    }
}
