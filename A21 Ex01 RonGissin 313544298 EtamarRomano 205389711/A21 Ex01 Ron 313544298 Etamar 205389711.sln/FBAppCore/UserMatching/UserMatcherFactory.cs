using System;

namespace FBAppCore.UserMatching
{
    internal static class UserMatcherFactory
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
