namespace FBFormAppNewFeatures
{
    partial class ApplicationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.ShowAlbumOfLabel = new System.Windows.Forms.Label();
            this.ShowAlbumsOfTextBox = new System.Windows.Forms.TextBox();
            this.ChangeAlbumOwnerButton = new System.Windows.Forms.Button();
            this.AlbumsLabel = new System.Windows.Forms.Label();
            this.AlbumsListView = new FBFormAppNewFeatures.PhotosListView();
            this.HiLoggedUserLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BestFriendLabel = new System.Windows.Forms.Label();
            this.BestFriendButton = new System.Windows.Forms.Button();
            this.MostLikedPhotoLabel = new System.Windows.Forms.Label();
            this.MostLikedPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.LogoutButton = new FBFormAppNewFeatures.Controls.RoundButton();
            this.BestMatchLabel = new System.Windows.Forms.Label();
            this.InterestedInLabel = new System.Windows.Forms.Label();
            this.MaleCheckBox = new System.Windows.Forms.CheckBox();
            this.FemaleCheckBox = new System.Windows.Forms.CheckBox();
            this.FindLoveButton = new System.Windows.Forms.Button();
            this.BestMatchPictureBox = new System.Windows.Forms.PictureBox();
            this.RememberUserCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MostLikedPhotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BestMatchPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfilePictureBox
            // 
            this.ProfilePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProfilePictureBox.Location = new System.Drawing.Point(14, 8);
            this.ProfilePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.ProfilePictureBox.Name = "ProfilePictureBox";
            this.ProfilePictureBox.Size = new System.Drawing.Size(155, 181);
            this.ProfilePictureBox.TabIndex = 1;
            this.ProfilePictureBox.TabStop = false;
            // 
            // ShowAlbumOfLabel
            // 
            this.ShowAlbumOfLabel.AutoSize = true;
            this.ShowAlbumOfLabel.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAlbumOfLabel.Location = new System.Drawing.Point(212, 41);
            this.ShowAlbumOfLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShowAlbumOfLabel.Name = "ShowAlbumOfLabel";
            this.ShowAlbumOfLabel.Size = new System.Drawing.Size(152, 22);
            this.ShowAlbumOfLabel.TabIndex = 2;
            this.ShowAlbumOfLabel.Text = "Show albums of";
            // 
            // ShowAlbumsOfTextBox
            // 
            this.ShowAlbumsOfTextBox.BackColor = System.Drawing.Color.PowderBlue;
            this.ShowAlbumsOfTextBox.Location = new System.Drawing.Point(376, 41);
            this.ShowAlbumsOfTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ShowAlbumsOfTextBox.Name = "ShowAlbumsOfTextBox";
            this.ShowAlbumsOfTextBox.Size = new System.Drawing.Size(313, 26);
            this.ShowAlbumsOfTextBox.TabIndex = 3;
            // 
            // ChangeAlbumOwnerButton
            // 
            this.ChangeAlbumOwnerButton.BackColor = System.Drawing.Color.LightYellow;
            this.ChangeAlbumOwnerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeAlbumOwnerButton.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeAlbumOwnerButton.Location = new System.Drawing.Point(693, 35);
            this.ChangeAlbumOwnerButton.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeAlbumOwnerButton.Name = "ChangeAlbumOwnerButton";
            this.ChangeAlbumOwnerButton.Size = new System.Drawing.Size(116, 38);
            this.ChangeAlbumOwnerButton.TabIndex = 4;
            this.ChangeAlbumOwnerButton.Text = "Apply";
            this.ChangeAlbumOwnerButton.UseVisualStyleBackColor = false;
            this.ChangeAlbumOwnerButton.Click += new System.EventHandler(this.ChangeAlbumOwnerButton_Click);
            // 
            // AlbumsLabel
            // 
            this.AlbumsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlbumsLabel.AutoSize = true;
            this.AlbumsLabel.BackColor = System.Drawing.Color.LightYellow;
            this.AlbumsLabel.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumsLabel.Location = new System.Drawing.Point(742, 122);
            this.AlbumsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AlbumsLabel.Name = "AlbumsLabel";
            this.AlbumsLabel.Size = new System.Drawing.Size(144, 41);
            this.AlbumsLabel.TabIndex = 5;
            this.AlbumsLabel.Text = "Albums";
            // 
            // AlbumsListView
            // 
            this.AlbumsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlbumsListView.BackColor = System.Drawing.Color.LightYellow;
            this.AlbumsListView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AlbumsListView.GridLines = true;
            this.AlbumsListView.HideSelection = false;
            this.AlbumsListView.Location = new System.Drawing.Point(611, 182);
            this.AlbumsListView.Margin = new System.Windows.Forms.Padding(2);
            this.AlbumsListView.Name = "AlbumsListView";
            this.AlbumsListView.Size = new System.Drawing.Size(625, 604);
            this.AlbumsListView.TabIndex = 6;
            this.AlbumsListView.UseCompatibleStateImageBehavior = false;
            this.AlbumsListView.DoubleClick += new System.EventHandler(this.AlbumsListView_DoubleClick);
            // 
            // HiLoggedUserLabel
            // 
            this.HiLoggedUserLabel.AutoSize = true;
            this.HiLoggedUserLabel.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HiLoggedUserLabel.Location = new System.Drawing.Point(12, 191);
            this.HiLoggedUserLabel.Name = "HiLoggedUserLabel";
            this.HiLoggedUserLabel.Size = new System.Drawing.Size(199, 22);
            this.HiLoggedUserLabel.TabIndex = 7;
            this.HiLoggedUserLabel.Text = "HiLoggedInUserText";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // BestFriendLabel
            // 
            this.BestFriendLabel.AutoSize = true;
            this.BestFriendLabel.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BestFriendLabel.Location = new System.Drawing.Point(12, 372);
            this.BestFriendLabel.Name = "BestFriendLabel";
            this.BestFriendLabel.Size = new System.Drawing.Size(279, 22);
            this.BestFriendLabel.TabIndex = 8;
            this.BestFriendLabel.Text = "Wanna find your best friend ?";
            // 
            // BestFriendButton
            // 
            this.BestFriendButton.BackColor = System.Drawing.Color.LightYellow;
            this.BestFriendButton.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BestFriendButton.Location = new System.Drawing.Point(320, 360);
            this.BestFriendButton.Name = "BestFriendButton";
            this.BestFriendButton.Size = new System.Drawing.Size(125, 47);
            this.BestFriendButton.TabIndex = 9;
            this.BestFriendButton.Text = "Show me !";
            this.BestFriendButton.UseVisualStyleBackColor = false;
            this.BestFriendButton.Click += new System.EventHandler(this.BestFriendButton_Click);
            // 
            // MostLikedPhotoLabel
            // 
            this.MostLikedPhotoLabel.AutoSize = true;
            this.MostLikedPhotoLabel.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostLikedPhotoLabel.Location = new System.Drawing.Point(398, 576);
            this.MostLikedPhotoLabel.Name = "MostLikedPhotoLabel";
            this.MostLikedPhotoLabel.Size = new System.Drawing.Size(163, 22);
            this.MostLikedPhotoLabel.TabIndex = 10;
            this.MostLikedPhotoLabel.Text = "Most liked photo";
            // 
            // MostLikedPhotoPictureBox
            // 
            this.MostLikedPhotoPictureBox.Location = new System.Drawing.Point(402, 619);
            this.MostLikedPhotoPictureBox.Name = "MostLikedPhotoPictureBox";
            this.MostLikedPhotoPictureBox.Size = new System.Drawing.Size(170, 167);
            this.MostLikedPhotoPictureBox.TabIndex = 11;
            this.MostLikedPhotoPictureBox.TabStop = false;
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.LightYellow;
            this.LogoutButton.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.Location = new System.Drawing.Point(16, 226);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(141, 45);
            this.LogoutButton.TabIndex = 12;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = false;
            // 
            // BestMatchLabel
            // 
            this.BestMatchLabel.AutoSize = true;
            this.BestMatchLabel.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BestMatchLabel.Location = new System.Drawing.Point(12, 512);
            this.BestMatchLabel.Name = "BestMatchLabel";
            this.BestMatchLabel.Size = new System.Drawing.Size(260, 22);
            this.BestMatchLabel.TabIndex = 13;
            this.BestMatchLabel.Text = "Find true love through likes";
            // 
            // InterestedInLabel
            // 
            this.InterestedInLabel.AutoSize = true;
            this.InterestedInLabel.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InterestedInLabel.Location = new System.Drawing.Point(12, 549);
            this.InterestedInLabel.Name = "InterestedInLabel";
            this.InterestedInLabel.Size = new System.Drawing.Size(174, 22);
            this.InterestedInLabel.TabIndex = 14;
            this.InterestedInLabel.Text = "I am interested in:";
            // 
            // MaleCheckBox
            // 
            this.MaleCheckBox.AutoSize = true;
            this.MaleCheckBox.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaleCheckBox.Location = new System.Drawing.Point(16, 595);
            this.MaleCheckBox.Name = "MaleCheckBox";
            this.MaleCheckBox.Size = new System.Drawing.Size(82, 26);
            this.MaleCheckBox.TabIndex = 15;
            this.MaleCheckBox.Text = "Male";
            this.MaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // FemaleCheckBox
            // 
            this.FemaleCheckBox.AutoSize = true;
            this.FemaleCheckBox.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemaleCheckBox.Location = new System.Drawing.Point(16, 627);
            this.FemaleCheckBox.Name = "FemaleCheckBox";
            this.FemaleCheckBox.Size = new System.Drawing.Size(103, 26);
            this.FemaleCheckBox.TabIndex = 15;
            this.FemaleCheckBox.Text = "Female";
            this.FemaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // FindLoveButton
            // 
            this.FindLoveButton.BackColor = System.Drawing.Color.LightYellow;
            this.FindLoveButton.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindLoveButton.Location = new System.Drawing.Point(147, 595);
            this.FindLoveButton.Name = "FindLoveButton";
            this.FindLoveButton.Size = new System.Drawing.Size(125, 47);
            this.FindLoveButton.TabIndex = 9;
            this.FindLoveButton.Text = "Find Out";
            this.FindLoveButton.UseVisualStyleBackColor = false;
            this.FindLoveButton.Click += new System.EventHandler(this.FindLoveButton_Click);
            // 
            // BestMatchPictureBox
            // 
            this.BestMatchPictureBox.Location = new System.Drawing.Point(119, 660);
            this.BestMatchPictureBox.Name = "BestMatchPictureBox";
            this.BestMatchPictureBox.Size = new System.Drawing.Size(153, 126);
            this.BestMatchPictureBox.TabIndex = 16;
            this.BestMatchPictureBox.TabStop = false;
            // 
            // RememberUserCheckBox
            // 
            this.RememberUserCheckBox.AutoSize = true;
            this.RememberUserCheckBox.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RememberUserCheckBox.Location = new System.Drawing.Point(16, 291);
            this.RememberUserCheckBox.Name = "RememberUserCheckBox";
            this.RememberUserCheckBox.Size = new System.Drawing.Size(169, 26);
            this.RememberUserCheckBox.TabIndex = 17;
            this.RememberUserCheckBox.Text = "Remember me";
            this.RememberUserCheckBox.UseVisualStyleBackColor = true;
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1317, 830);
            this.Controls.Add(this.RememberUserCheckBox);
            this.Controls.Add(this.BestMatchPictureBox);
            this.Controls.Add(this.FemaleCheckBox);
            this.Controls.Add(this.MaleCheckBox);
            this.Controls.Add(this.InterestedInLabel);
            this.Controls.Add(this.BestMatchLabel);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.MostLikedPhotoPictureBox);
            this.Controls.Add(this.MostLikedPhotoLabel);
            this.Controls.Add(this.FindLoveButton);
            this.Controls.Add(this.BestFriendButton);
            this.Controls.Add(this.BestFriendLabel);
            this.Controls.Add(this.HiLoggedUserLabel);
            this.Controls.Add(this.AlbumsListView);
            this.Controls.Add(this.AlbumsLabel);
            this.Controls.Add(this.ChangeAlbumOwnerButton);
            this.Controls.Add(this.ShowAlbumsOfTextBox);
            this.Controls.Add(this.ShowAlbumOfLabel);
            this.Controls.Add(this.ProfilePictureBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ApplicationForm";
            this.Text = "Facebook Pics Explorer";
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MostLikedPhotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BestMatchPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ProfilePictureBox;
        private System.Windows.Forms.Label ShowAlbumOfLabel;
        private System.Windows.Forms.TextBox ShowAlbumsOfTextBox;
        private System.Windows.Forms.Button ChangeAlbumOwnerButton;
        private System.Windows.Forms.Label AlbumsLabel;
        private PhotosListView AlbumsListView;
        private System.Windows.Forms.Label HiLoggedUserLabel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label BestFriendLabel;
        private System.Windows.Forms.Button BestFriendButton;
        private System.Windows.Forms.Label MostLikedPhotoLabel;
        private System.Windows.Forms.PictureBox MostLikedPhotoPictureBox;
        private Controls.RoundButton LogoutButton;
        private System.Windows.Forms.Label BestMatchLabel;
        private System.Windows.Forms.Label InterestedInLabel;
        private System.Windows.Forms.CheckBox MaleCheckBox;
        private System.Windows.Forms.CheckBox FemaleCheckBox;
        private System.Windows.Forms.Button FindLoveButton;
        private System.Windows.Forms.PictureBox BestMatchPictureBox;
        private System.Windows.Forms.CheckBox RememberUserCheckBox;
    }
}