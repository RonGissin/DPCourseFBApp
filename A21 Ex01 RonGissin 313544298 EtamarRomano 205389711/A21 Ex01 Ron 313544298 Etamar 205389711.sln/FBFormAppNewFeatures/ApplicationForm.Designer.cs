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
            this.PostStatusLabel = new System.Windows.Forms.Label();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.PostButton = new System.Windows.Forms.Button();
            this.AlbumsLabel = new System.Windows.Forms.Label();
            this.FriendsLabel = new System.Windows.Forms.Label();
            this.GroupsLabel = new System.Windows.Forms.Label();
            this.AlbumsListBox = new System.Windows.Forms.ListBox();
            this.FriendsListBox = new System.Windows.Forms.ListBox();
            this.GroupsListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(78, 310);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(154, 49);
            this.LogoutButton.TabIndex = 0;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            // 
            // ProfilePictureBox
            // 
            this.ProfilePictureBox.Location = new System.Drawing.Point(25, 12);
            this.ProfilePictureBox.Name = "ProfilePictureBox";
            this.ProfilePictureBox.Size = new System.Drawing.Size(276, 280);
            this.ProfilePictureBox.TabIndex = 1;
            this.ProfilePictureBox.TabStop = false;
            // 
            // PostStatusLabel
            // 
            this.PostStatusLabel.AutoSize = true;
            this.PostStatusLabel.Location = new System.Drawing.Point(377, 32);
            this.PostStatusLabel.Name = "PostStatusLabel";
            this.PostStatusLabel.Size = new System.Drawing.Size(293, 32);
            this.PostStatusLabel.TabIndex = 2;
            this.PostStatusLabel.Text = "What\'s on your mind ?";
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Location = new System.Drawing.Point(676, 32);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(554, 38);
            this.StatusTextBox.TabIndex = 3;
            // 
            // PostButton
            // 
            this.PostButton.Location = new System.Drawing.Point(1251, 32);
            this.PostButton.Name = "PostButton";
            this.PostButton.Size = new System.Drawing.Size(100, 39);
            this.PostButton.TabIndex = 4;
            this.PostButton.Text = "Post";
            this.PostButton.UseVisualStyleBackColor = true;
            // 
            // AlbumsLabel
            // 
            this.AlbumsLabel.AutoSize = true;
            this.AlbumsLabel.Location = new System.Drawing.Point(518, 260);
            this.AlbumsLabel.Name = "AlbumsLabel";
            this.AlbumsLabel.Size = new System.Drawing.Size(110, 32);
            this.AlbumsLabel.TabIndex = 5;
            this.AlbumsLabel.Text = "Albums";
            // 
            // FriendsLabel
            // 
            this.FriendsLabel.AutoSize = true;
            this.FriendsLabel.Location = new System.Drawing.Point(1162, 260);
            this.FriendsLabel.Name = "FriendsLabel";
            this.FriendsLabel.Size = new System.Drawing.Size(110, 32);
            this.FriendsLabel.TabIndex = 5;
            this.FriendsLabel.Text = "Friends";
            // 
            // GroupsLabel
            // 
            this.GroupsLabel.AutoSize = true;
            this.GroupsLabel.Location = new System.Drawing.Point(1855, 260);
            this.GroupsLabel.Name = "GroupsLabel";
            this.GroupsLabel.Size = new System.Drawing.Size(108, 32);
            this.GroupsLabel.TabIndex = 5;
            this.GroupsLabel.Text = "Groups";
            // 
            // AlbumsListBox
            // 
            this.AlbumsListBox.FormattingEnabled = true;
            this.AlbumsListBox.ItemHeight = 31;
            this.AlbumsListBox.Location = new System.Drawing.Point(310, 356);
            this.AlbumsListBox.Name = "AlbumsListBox";
            this.AlbumsListBox.Size = new System.Drawing.Size(563, 593);
            this.AlbumsListBox.TabIndex = 6;
            // 
            // FriendsListBox
            // 
            this.FriendsListBox.FormattingEnabled = true;
            this.FriendsListBox.ItemHeight = 31;
            this.FriendsListBox.Location = new System.Drawing.Point(981, 356);
            this.FriendsListBox.Name = "FriendsListBox";
            this.FriendsListBox.Size = new System.Drawing.Size(563, 593);
            this.FriendsListBox.TabIndex = 6;
            // 
            // GroupsListBox
            // 
            this.GroupsListBox.FormattingEnabled = true;
            this.GroupsListBox.ItemHeight = 31;
            this.GroupsListBox.Location = new System.Drawing.Point(1632, 356);
            this.GroupsListBox.Name = "GroupsListBox";
            this.GroupsListBox.Size = new System.Drawing.Size(563, 593);
            this.GroupsListBox.TabIndex = 6;
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2341, 1287);
            this.Controls.Add(this.GroupsListBox);
            this.Controls.Add(this.FriendsListBox);
            this.Controls.Add(this.AlbumsListBox);
            this.Controls.Add(this.GroupsLabel);
            this.Controls.Add(this.FriendsLabel);
            this.Controls.Add(this.AlbumsLabel);
            this.Controls.Add(this.PostButton);
            this.Controls.Add(this.StatusTextBox);
            this.Controls.Add(this.PostStatusLabel);
            this.Controls.Add(this.ProfilePictureBox);
            this.Controls.Add(this.LogoutButton);
            this.Name = "ApplicationForm";
            this.Text = "ApplicationForm";
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.PictureBox ProfilePictureBox;
        private System.Windows.Forms.Label PostStatusLabel;
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.Button PostButton;
        private System.Windows.Forms.Label AlbumsLabel;
        private System.Windows.Forms.Label FriendsLabel;
        private System.Windows.Forms.Label GroupsLabel;
        private System.Windows.Forms.ListBox AlbumsListBox;
        private System.Windows.Forms.ListBox FriendsListBox;
        private System.Windows.Forms.ListBox GroupsListBox;
    }
}