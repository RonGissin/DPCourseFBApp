using FacebookWrapper.ObjectModel;

namespace FBAppCore
{
    public interface ILikeHandler
    {
        bool IsLikedBy(PostedItem i_PostedItem, User i_User);

        void Like(PostedItem i_PostedItem);

        void Unlike(PostedItem i_PostedItem);
    }
}
