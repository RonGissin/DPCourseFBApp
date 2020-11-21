using FacebookWrapper.ObjectModel;

namespace FBAppCore
{
    public class LikeHandler : ILikeHandler
    {
        public bool IsLikedBy(PostedItem i_PostedItem, User i_User)
        {
            return i_PostedItem.LikedBy.Contains(i_User);
        }

        public void Like(PostedItem i_PostedItem)
        {
            i_PostedItem.Like();
        }

        public void Unlike(PostedItem i_PostedItem)
        {
            i_PostedItem.Unlike();
        }
    }
}
