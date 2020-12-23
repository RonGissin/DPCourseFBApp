using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBAppCore
{
    public static class UserMatcherFactory
    {
        public static IUserMatcher CreateMatcher(eUserMatcherType i_MatcherType) 
        {
            switch (i_MatcherType)
            {
                case eUserMatcherType.BestFriendMatcher:
                    return new BestFriendMatcher();
                case eUserMatcherType.TrueLoveMatcher:
                    return new TrueLoveMatcher();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
