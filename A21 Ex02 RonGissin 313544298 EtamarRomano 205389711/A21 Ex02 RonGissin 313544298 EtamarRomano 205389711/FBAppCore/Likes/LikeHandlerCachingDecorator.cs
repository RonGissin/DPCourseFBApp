using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FBAppCore.Likes
{
    internal class LikeHandlerCachingDecorator : LikeHandlerBaseDecorator
    {
        private HashSet<string> m_LikedItemsIds;
        private HashSet<string> m_UnlikedItemsIds;

        public LikeHandlerCachingDecorator(ILikeHandler i_DecoratedLikeHandler)
            : base(i_DecoratedLikeHandler)
        {
            m_LikedItemsIds = new HashSet<string>();
            m_UnlikedItemsIds = new HashSet<string>();
        }

        public override void Like(PostedItem i_PostedItem)
        {
            if (m_LikedItemsIds.Add(i_PostedItem.Id))
            {
                base.Like(i_PostedItem);
            }

            m_UnlikedItemsIds.Remove(i_PostedItem.Id);
        }

        public override void Unlike(PostedItem i_PostedItem)
        {
            if (m_UnlikedItemsIds.Add(i_PostedItem.Id))
            {
                base.Unlike(i_PostedItem);
            }

            m_LikedItemsIds.Remove(i_PostedItem.Id);
        }
    }
}
