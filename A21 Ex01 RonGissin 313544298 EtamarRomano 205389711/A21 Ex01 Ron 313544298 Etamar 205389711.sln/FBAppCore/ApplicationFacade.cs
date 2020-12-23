using FacebookWrapper.ObjectModel;
using FBAppCore.Login;
using FBAppInfra.Validation;
using System;
using System.Collections.Generic;

namespace FBAppCore
{
    public sealed class ApplicationFacade
    {
        public static ApplicationFacade Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_ObjLock)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new ApplicationFacade();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public User AlbumUser 
        {
            get 
            {
                return m_AlbumUser;
            }

            set
            {
                m_AlbumUser = value;
                m_ThreadRunner.RunMethodAsSeperateThread(fetchUserAlbums);
            } 
        }

       
        public User LoggedInUser { get; set; }

        public IEnumerable<Album> Albums { get; set; }

        private static ApplicationFacade s_Instance = null;

        private static readonly object sr_ObjLock = new object();

        private User m_AlbumUser;

        private IUserMatcher m_BestFriendMatcher { get; set; }

        private IUserMatcher m_TrueLoveMatcher { get; set; }

        private ThreadRunner m_ThreadRunner { get; set; }

        private ApplicationFacade()
        {
            m_BestFriendMatcher = UserMatcherFactory.CreateMatcher(eUserMatcherType.BestFriendMatcher);
            m_TrueLoveMatcher = UserMatcherFactory.CreateMatcher(eUserMatcherType.TrueLoveMatcher);
            m_ThreadRunner = new ThreadRunner();
        }

        public User FindBestMatch(User i_UserToMatchTo, Func<User, bool> i_FilterFunc)
            => m_TrueLoveMatcher.FindMatch(i_UserToMatchTo, i_FilterFunc);

        public User FindTrueLove(User i_UserToMatchTo, Func<User, bool> i_FilterFunc)
            => m_BestFriendMatcher.FindMatch(i_UserToMatchTo, i_FilterFunc);


        private void fetchUserAlbums()
        {
            Albums = m_AlbumUser.Albums;
        }

    }
}
