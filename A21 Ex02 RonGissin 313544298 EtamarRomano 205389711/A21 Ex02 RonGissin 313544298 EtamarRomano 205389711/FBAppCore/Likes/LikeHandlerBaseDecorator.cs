using FacebookWrapper.ObjectModel;
using FBAppCore.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBAppCore.Likes
{
    internal abstract class LikeHandlerBaseDecorator : ILikeHandler
    {
        public ILikeHandler m_DecoratedLikeHandler { get; set; }

        public LikeHandlerBaseDecorator(ILikeHandler i_DecoratedLikeHandler)
        {
            m_DecoratedLikeHandler = InputGuard.CheckNullArgument(i_DecoratedLikeHandler, nameof(i_DecoratedLikeHandler));
        }

        public virtual bool IsLikedBy(PostedItem i_PostedItem, User i_User)
            => m_DecoratedLikeHandler.IsLikedBy(i_PostedItem, i_User);

        public virtual void Like(PostedItem i_PostedItem)
            => m_DecoratedLikeHandler.Like(i_PostedItem);

        public virtual void Unlike(PostedItem i_PostedItem)
            => m_DecoratedLikeHandler.Like(i_PostedItem);
    }
}
