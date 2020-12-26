using FacebookWrapper.ObjectModel;
using FBAppCore.Likes;
using FBAppCore.UserMatching;
using System;

namespace FBAppCore
{
    public sealed class ApplicationLogicHandler
    {
        public static ApplicationLogicHandler Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_ObjLock)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new ApplicationLogicHandler();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public User AlbumUser { get; set; }
       
        public User LoggedInUser { get; set; }

        private static ApplicationLogicHandler s_Instance = null;

        private static readonly object sr_ObjLock = new object();

        private readonly IUserMatcher m_BestFriendMatcher;

        private readonly IUserMatcher m_TrueLoveMatcher; 

        private readonly ILikeHandler m_LikeHandler;

        private ApplicationLogicHandler()
        {
            m_BestFriendMatcher = UserMatcherFactory.CreateMatcher(eUserMatcherType.BestFriendMatcher);
            m_TrueLoveMatcher = UserMatcherFactory.CreateMatcher(eUserMatcherType.TrueLoveMatcher);
            m_LikeHandler = new LikeHandler();
        }

        public User FindBestFriend(User i_UserToMatchTo, Func<User, bool> i_FilterFunc)
            => m_TrueLoveMatcher.FindMatch(i_UserToMatchTo, i_FilterFunc);

        public User FindTrueLove(User i_UserToMatchTo, Func<User, bool> i_FilterFunc)
            => m_BestFriendMatcher.FindMatch(i_UserToMatchTo, i_FilterFunc);

        public bool IsItemLikedByUser(PostedItem i_PostedItem, User i_User)
            => m_LikeHandler.IsLikedBy(i_PostedItem, i_User);

        public void LikeItem(PostedItem i_PostedItem)
            => m_LikeHandler.Like(i_PostedItem);

        public void UnlikeItem(PostedItem i_PostedItem)
            => m_LikeHandler.Unlike(i_PostedItem);
    }
}
