using FacebookWrapper.ObjectModel;

namespace FBAppCore
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
