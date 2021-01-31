using System;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace FBAppCore.UserMatching
{
    internal class TrueLoveMatcher : IUserMatcher
    {
        public User FindMatch(User i_UserToMatchTo, Func<User, bool> i_FilterFunc)
        {
            User bestMatch;

            try
            {
                bestMatch = i_UserToMatchTo.Albums
                .SelectMany(album => album.Photos)
                .SelectMany(photo => photo.LikedBy)
                .Where(i_FilterFunc)
                .GroupBy(likedby => likedby.Name)
                .OrderByDescending(group => group.Count())
                .FirstOrDefault()
                .FirstOrDefault();
            }
            catch 
            {
                // if no match found, return the matchee.
                bestMatch = i_UserToMatchTo;
            }

            return bestMatch;
        }
    }
}
