using FacebookWrapper.ObjectModel;

namespace FBAppCore
{
    public interface ILikeHandler
    {
        bool IsLikedBy(PostedItem postedItem, User user);
        void Like(PostedItem postedItem);

        void Unlike(PostedItem postedItem);
    }
}
