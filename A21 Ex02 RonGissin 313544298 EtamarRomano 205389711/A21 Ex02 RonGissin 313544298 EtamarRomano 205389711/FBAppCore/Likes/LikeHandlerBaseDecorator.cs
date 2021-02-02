using FacebookWrapper.ObjectModel;
using FBAppCore.Validation;

namespace FBAppCore.Likes
{
    internal abstract class LikeHandlerBaseDecorator : ILikeHandler
    {
        private readonly ILikeHandler r_DecoratedLikeHandler;

        public LikeHandlerBaseDecorator(ILikeHandler i_DecoratedLikeHandler)
        {
            r_DecoratedLikeHandler = InputGuard.CheckNullArgument(i_DecoratedLikeHandler, nameof(i_DecoratedLikeHandler));
        }

        public virtual bool IsLikedBy(PostedItem i_PostedItem, User i_User)
            => r_DecoratedLikeHandler.IsLikedBy(i_PostedItem, i_User);

        public virtual void Like(PostedItem i_PostedItem)
            => r_DecoratedLikeHandler.Like(i_PostedItem);

        public virtual void Unlike(PostedItem i_PostedItem)
            => r_DecoratedLikeHandler.Like(i_PostedItem);
    }
}
