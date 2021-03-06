﻿using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FBAppCore;
using FBAppInfra.Validation;

namespace FBAppUI.Forms
{
    public partial class ImageForm : Form, IDataInjectable
    {
        private const string k_LikeUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/54/Bot%C3%B3n_Me_gusta.svg/1200px-Bot%C3%B3n_Me_gusta.svg.png";
        private const string k_UnlikeUrl = "https://humans-first.com/wp-content/uploads/2018/11/How-to-Unlike-Multiple-Facebook-Pages-at-Once-e1542361859101.png";
        private Photo m_Photo;
        private User m_LoggedInUser;
        private ILikeHandler m_LikeHandler;
        private bool m_IsImageLiked;

        public ImageForm(Photo i_Photo, User i_LoggedInUser)
        {
            m_Photo = InputGuard.CheckNullArgument(i_Photo, nameof(i_Photo));
            m_LoggedInUser = InputGuard.CheckNullArgument(i_LoggedInUser, nameof(i_LoggedInUser));
            m_LikeHandler = new LikeHandler();
            m_IsImageLiked = false;

            InitializeComponent();
            CenterToScreen();
        }

        public void InjectData()
        {
            Text = m_Photo.Name;
            ImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ImagePictureBox.Image = m_Photo.ImageNormal;
            LikePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        protected override void OnShown(EventArgs i_EventArgs)
        {
            base.OnShown(i_EventArgs);

            InjectData();
        }

        private bool isPhotoLikedByUser()
        {
            return m_LikeHandler.IsLikedBy(m_Photo, m_LoggedInUser);
        }

        private void likePictureBox_DoubleClick(object i_Sender, EventArgs i_EventArgs)
        {
            toggleLikeUnlike();
        }

        private void imageCommentBox_KeyPress(object i_Sender, KeyPressEventArgs i_EventArgs)
        {
            if(i_EventArgs.KeyChar == (char)Keys.Enter)
            {
                postComment();
            }
        }

        private void imageForm_Load(object i_Sender, EventArgs i_EventArgs)
        {
            if (isPhotoLikedByUser())
            {
                LikePictureBox.LoadAsync(k_UnlikeUrl);
                m_IsImageLiked = true;
            }
            else
            {
                LikePictureBox.LoadAsync(k_LikeUrl);
                m_IsImageLiked = false;
            }

            LikePictureBox.Refresh();
        }

        private void postComment()
        {
            // FacebookWrapper.dll throws exception - commenting is deprecated.
            try
            {
                m_Photo.Comment(ImageCommentBox.Text);
            }
            catch
            {
            }

            ImageCommentBox.Clear();
            ImageCommentBox.Font = new Font(ImageCommentBox.Font, FontStyle.Bold);
            ImageCommentBox.Text = "Comment Posted !";
            ImageCommentBox.Refresh();
            Thread.Sleep(2000);
            ImageCommentBox.Font = new Font(ImageCommentBox.Font, FontStyle.Regular);
            ImageCommentBox.Clear();
        }

        private void disposeOfImageIfNeeded(PictureBox i_PictureBox)
        {
            if (i_PictureBox.Image != null)
            {
                i_PictureBox.Image.Dispose();
                i_PictureBox.Image = null;
            }
        }

        private void toggleLikeUnlike()
        {
            try
            {
                disposeOfImageIfNeeded(LikePictureBox);

                if (!m_IsImageLiked)
                {
                    LikePictureBox.LoadAsync(k_UnlikeUrl);
                    m_LikeHandler.Like(m_Photo);
                }
                else
                {
                    LikePictureBox.LoadAsync(k_LikeUrl);
                    m_LikeHandler.Unlike(m_Photo);
                }
            }
            catch
            {
            }
            finally
            {
                LikePictureBox.Refresh();
            }
        }
    }
}
