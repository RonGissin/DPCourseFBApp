using FacebookWrapper.ObjectModel;
using FBAppCore;
using FBAppInfra.Validation;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace FBAppUI.Forms
{
    public partial class ImageForm : Form
    {
        private Photo m_Photo;
        private User m_LoggedInUser;
        private ILikeHandler m_LikeHandler;
        private bool m_IsImageLiked;
        private const string c_LikeUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/54/Bot%C3%B3n_Me_gusta.svg/1200px-Bot%C3%B3n_Me_gusta.svg.png";
        private const string c_UnlikeUrl = "https://humans-first.com/wp-content/uploads/2018/11/How-to-Unlike-Multiple-Facebook-Pages-at-Once-e1542361859101.png";

        public ImageForm(Photo i_Photo, User i_LoggedInUser)
        {
            m_Photo = InputGuard.CheckNullArgument(i_Photo, nameof(i_Photo));
            m_LoggedInUser = InputGuard.CheckNullArgument(i_LoggedInUser, nameof(i_LoggedInUser));
            m_LikeHandler = new LikeHandler();
            m_IsImageLiked = false;

            InitializeComponent();
            CenterToScreen();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            InjectUserData();
        }

        private void InjectUserData()
        {
            Text = m_Photo.Name;
            ImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ImagePictureBox.Image = m_Photo.ImageNormal;
            LikePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private bool isPhotoLikedByUser()
        {
            return m_LikeHandler.IsLikedBy(m_Photo, m_LoggedInUser);
        }

        private void LikePictureBox_DoubleClick(object sender, EventArgs e)
        {
            ToggleLikeUnlike();
        }

        private void ImageLikeButton_Click(object sender, EventArgs e)
        {
            ToggleLikeUnlike();
        }

        private void ImageCommentBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                PostComment();
            }
        }

        private void ImageForm_Load(object sender, EventArgs e)
        {
            if (isPhotoLikedByUser())
            {
                LikePictureBox.LoadAsync(c_UnlikeUrl);
                m_IsImageLiked = true;
            }
            else
            {
                LikePictureBox.LoadAsync(c_LikeUrl);
                m_IsImageLiked = false;
            }

            LikePictureBox.Refresh();
        }

        private void PostComment()
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

        private void ToggleLikeUnlike()
        {
            try
            {
                if (!m_IsImageLiked)
                {
                    LikePictureBox.LoadAsync(c_UnlikeUrl);
                    m_LikeHandler.Like(m_Photo);
                }
                else
                {
                    LikePictureBox.LoadAsync(c_LikeUrl);
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
