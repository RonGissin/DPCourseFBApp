using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBAppCore.UserMatching
{
    internal class BestFriendMatcher : IUserMatcher
    {
        public User FindMatch(User i_UserToMatchTo, Func<User, bool> i_FilterFunc)
        {
            User bestFriend;

            try
            {
                bestFriend = i_UserToMatchTo.Albums
                .SelectMany(album => album.Photos)
                .SelectMany(photo => photo.Tags)
                .GroupBy(tag => tag.User)
                .Where(gp => i_FilterFunc(gp.Key))
                .OrderByDescending(gp => gp.Count())
                .FirstOrDefault()
                .FirstOrDefault()
                ?.User;
            }
            catch
            {
                bestFriend = i_UserToMatchTo;
            }

            return bestFriend;
        }
    }
}
