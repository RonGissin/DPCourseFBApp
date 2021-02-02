using System;
using FacebookWrapper.ObjectModel;
using FBAppCore.Logging;

namespace FBAppCore.Likes
{
    internal class LikeHandlerLogUsageDecorator : LikeHandlerBaseDecorator
    {
        private ILogger m_Logger;
        
        public LikeHandlerLogUsageDecorator(ILikeHandler i_DecoratedLikeHandler, string i_LogFilePath) : base(i_DecoratedLikeHandler)
        {
            m_Logger = Logger.Create(i_LogFilePath);
        }

        public override void Like(PostedItem i_PostedItem)
        {
            try
            {
                base.Like(i_PostedItem);
                m_Logger.LogInfo($"The item with ID - {i_PostedItem.Id} has just been liked.");
            }
            catch (Exception exception)
            {
                m_Logger.LogInfo($"An error occurred when trying to like the item with ID - {i_PostedItem.Id}. Exception={exception}");
                throw;
            }
        }

        public override void Unlike(PostedItem i_PostedItem)
        {
            try
            {
                base.Unlike(i_PostedItem);
                m_Logger.LogInfo($"The item with ID - {i_PostedItem.Id} has just been unliked.");
            }
            catch (Exception exception)
            {
                m_Logger.LogInfo($"An error occurred when trying to unlike the item with ID - {i_PostedItem.Id}. Exception={exception}");
                throw;
            }
        }
    }
}
