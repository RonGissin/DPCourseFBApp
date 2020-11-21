using FacebookWrapper.ObjectModel;
using System;
using System.Linq;

namespace FBAppCore
{
    public class UserMatcher
    {
        public User FindMatch(User i_UserToMatchTo, Func<User, bool> filterFunc)
        {
            User bestMatch;

            try
            {
                bestMatch = i_UserToMatchTo.Albums
                .SelectMany(album => album.Photos)
                .SelectMany(photo => photo.LikedBy)
                .Where(filterFunc)
                .GroupBy(likedby => likedby.Name)
                .OrderByDescending(group => group.Count())
                .FirstOrDefault()
                .FirstOrDefault();
            }
            catch (ArgumentNullException exception)
            {
                // if no match found, return the matchee.
                bestMatch = i_UserToMatchTo;
            }

            return bestMatch;
        }
    }
}
