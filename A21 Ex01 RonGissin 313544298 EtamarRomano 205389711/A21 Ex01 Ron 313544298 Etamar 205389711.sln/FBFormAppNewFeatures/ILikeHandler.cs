using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBFormAppNewFeatures
{
    public interface ILikeHandler
    {
        bool IsLikedBy(PostedItem postedItem, User user);
        void Like(PostedItem postedItem);

        void Unlike(PostedItem postedItem);
    }
}
