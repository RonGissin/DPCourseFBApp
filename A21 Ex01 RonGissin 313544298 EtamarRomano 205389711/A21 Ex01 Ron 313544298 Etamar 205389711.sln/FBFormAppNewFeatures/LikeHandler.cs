using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBFormAppNewFeatures
{
    public class LikeHandler : ILikeHandler
    {
        public bool IsLikedBy(PostedItem postedItem, User user)
        {
            return postedItem.LikedBy.Contains(user);
        }

        public void Like(PostedItem postedItem)
        {
            postedItem.Like();
        }

        public void Unlike(PostedItem postedItem)
        {
            postedItem.Unlike();
        }
    }
}
