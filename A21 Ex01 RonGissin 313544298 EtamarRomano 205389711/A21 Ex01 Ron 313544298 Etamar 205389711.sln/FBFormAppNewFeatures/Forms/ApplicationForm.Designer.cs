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
            this.LogoutButton = new System.Windows.Forms.Button();
            this.ProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.ShowAlbumOfLabel = new System.Windows.Forms.Label();
            this.ShowAlbumsOfTextBox = new System.Windows.Forms.TextBox();
            this.ChangeAlbumOwnerButton = new System.Windows.Forms.Button();
            this.AlbumsLabel = new System.Windows.Forms.Label();
            this.AlbumsListView = new FBFormAppNewFeatures.PhotosListView();
            this.HiLoggedUserLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.LightYellow;
            this.LogoutButton.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.Location = new System.Drawing.Point(36, 227);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(104, 49);
            this.LogoutButton.TabIndex = 0;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // ProfilePictureBox
            // 
            this.ProfilePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProfilePictureBox.Location = new System.Drawing.Point(14, 8);
            this.ProfilePictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.ShowAlbumOfLabel.Click += new System.EventHandler(this.PostStatusLabel_Click);
            // 
            // ShowAlbumsOfTextBox
            // 
            this.ShowAlbumsOfTextBox.BackColor = System.Drawing.Color.PowderBlue;
            this.ShowAlbumsOfTextBox.Location = new System.Drawing.Point(376, 41);
            this.ShowAlbumsOfTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.ChangeAlbumOwnerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.AlbumsLabel.Location = new System.Drawing.Point(499, 120);
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
            this.AlbumsListView.Location = new System.Drawing.Point(376, 174);
            this.AlbumsListView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AlbumsListView.Name = "AlbumsListView";
            this.AlbumsListView.Size = new System.Drawing.Size(625, 604);
            this.AlbumsListView.TabIndex = 6;
            this.AlbumsListView.UseCompatibleStateImageBehavior = false;
            this.AlbumsListView.SelectedIndexChanged += new System.EventHandler(this.AlbumsListView_SelectedIndexChanged);
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
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1317, 830);
            this.Controls.Add(this.HiLoggedUserLabel);
            this.Controls.Add(this.AlbumsListView);
            this.Controls.Add(this.AlbumsLabel);
            this.Controls.Add(this.ChangeAlbumOwnerButton);
            this.Controls.Add(this.ShowAlbumsOfTextBox);
            this.Controls.Add(this.ShowAlbumOfLabel);
            this.Controls.Add(this.ProfilePictureBox);
            this.Controls.Add(this.LogoutButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ApplicationForm";
            this.Text = "Facebook Pics";
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.PictureBox ProfilePictureBox;
        private System.Windows.Forms.Label ShowAlbumOfLabel;
        private System.Windows.Forms.TextBox ShowAlbumsOfTextBox;
        private System.Windows.Forms.Button ChangeAlbumOwnerButton;
        private System.Windows.Forms.Label AlbumsLabel;
        private PhotosListView AlbumsListView;
        private System.Windows.Forms.Label HiLoggedUserLabel;
    }
}