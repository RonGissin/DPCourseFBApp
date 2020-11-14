namespace FBFormAppNewFeatures.Forms
{
    partial class AlbumPhotosForm
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
            this.AlbumPhotosListView = new FBFormAppNewFeatures.PhotosListView();
            this.AlbumLikesLabel = new System.Windows.Forms.Label();
            this.NumAlbumLikesLabel = new System.Windows.Forms.Label();
            this.AlbumTagsLabel = new System.Windows.Forms.Label();
            this.AlbumTagsListBox = new System.Windows.Forms.ListBox();
            this.AlbumLocationLabel = new System.Windows.Forms.Label();
            this.AlbumLocationData = new System.Windows.Forms.Label();
            this.AlbumDescriptionLabel = new System.Windows.Forms.Label();
            this.AlbumDescriptionData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AlbumPhotosListView
            // 
            this.AlbumPhotosListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlbumPhotosListView.BackColor = System.Drawing.Color.LightYellow;
            this.AlbumPhotosListView.GridLines = true;
            this.AlbumPhotosListView.HideSelection = false;
            this.AlbumPhotosListView.Location = new System.Drawing.Point(20, 24);
            this.AlbumPhotosListView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AlbumPhotosListView.Name = "AlbumPhotosListView";
            this.AlbumPhotosListView.Size = new System.Drawing.Size(623, 732);
            this.AlbumPhotosListView.TabIndex = 0;
            this.AlbumPhotosListView.UseCompatibleStateImageBehavior = false;
            this.AlbumPhotosListView.DoubleClick += new System.EventHandler(this.AlbumPhotosListView_DoubleClick);
            // 
            // AlbumLikesLabel
            // 
            this.AlbumLikesLabel.AutoSize = true;
            this.AlbumLikesLabel.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumLikesLabel.Location = new System.Drawing.Point(21, 849);
            this.AlbumLikesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AlbumLikesLabel.Name = "AlbumLikesLabel";
            this.AlbumLikesLabel.Size = new System.Drawing.Size(129, 22);
            this.AlbumLikesLabel.TabIndex = 1;
            this.AlbumLikesLabel.Text = "Album Likes:";
            // 
            // NumAlbumLikesLabel
            // 
            this.NumAlbumLikesLabel.AutoSize = true;
            this.NumAlbumLikesLabel.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumAlbumLikesLabel.Location = new System.Drawing.Point(148, 849);
            this.NumAlbumLikesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NumAlbumLikesLabel.Name = "NumAlbumLikesLabel";
            this.NumAlbumLikesLabel.Size = new System.Drawing.Size(21, 22);
            this.NumAlbumLikesLabel.TabIndex = 2;
            this.NumAlbumLikesLabel.Text = "0";
            // 
            // AlbumTagsLabel
            // 
            this.AlbumTagsLabel.AutoSize = true;
            this.AlbumTagsLabel.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumTagsLabel.Location = new System.Drawing.Point(240, 849);
            this.AlbumTagsLabel.Name = "AlbumTagsLabel";
            this.AlbumTagsLabel.Size = new System.Drawing.Size(173, 22);
            this.AlbumTagsLabel.TabIndex = 3;
            this.AlbumTagsLabel.Text = "Tagged in album:";
            // 
            // AlbumTagsListBox
            // 
            this.AlbumTagsListBox.BackColor = System.Drawing.Color.LightYellow;
            this.AlbumTagsListBox.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumTagsListBox.FormattingEnabled = true;
            this.AlbumTagsListBox.ItemHeight = 22;
            this.AlbumTagsListBox.Location = new System.Drawing.Point(432, 849);
            this.AlbumTagsListBox.Name = "AlbumTagsListBox";
            this.AlbumTagsListBox.Size = new System.Drawing.Size(211, 92);
            this.AlbumTagsListBox.TabIndex = 4;
            // 
            // AlbumLocationLabel
            // 
            this.AlbumLocationLabel.AutoSize = true;
            this.AlbumLocationLabel.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumLocationLabel.Location = new System.Drawing.Point(21, 898);
            this.AlbumLocationLabel.Name = "AlbumLocationLabel";
            this.AlbumLocationLabel.Size = new System.Drawing.Size(93, 22);
            this.AlbumLocationLabel.TabIndex = 5;
            this.AlbumLocationLabel.Text = "Taken at:";
            // 
            // AlbumLocationData
            // 
            this.AlbumLocationData.AutoSize = true;
            this.AlbumLocationData.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumLocationData.Location = new System.Drawing.Point(150, 898);
            this.AlbumLocationData.Name = "AlbumLocationData";
            this.AlbumLocationData.Size = new System.Drawing.Size(19, 22);
            this.AlbumLocationData.TabIndex = 6;
            this.AlbumLocationData.Text = "?";
            // 
            // AlbumDescriptionLabel
            // 
            this.AlbumDescriptionLabel.AutoSize = true;
            this.AlbumDescriptionLabel.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumDescriptionLabel.Location = new System.Drawing.Point(25, 796);
            this.AlbumDescriptionLabel.Name = "AlbumDescriptionLabel";
            this.AlbumDescriptionLabel.Size = new System.Drawing.Size(122, 22);
            this.AlbumDescriptionLabel.TabIndex = 7;
            this.AlbumDescriptionLabel.Text = "Description:";
            // 
            // AlbumDescriptionData
            // 
            this.AlbumDescriptionData.AutoSize = true;
            this.AlbumDescriptionData.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumDescriptionData.Location = new System.Drawing.Point(154, 796);
            this.AlbumDescriptionData.Name = "AlbumDescriptionData";
            this.AlbumDescriptionData.Size = new System.Drawing.Size(114, 22);
            this.AlbumDescriptionData.TabIndex = 8;
            this.AlbumDescriptionData.Text = "description";
            // 
            // AlbumPhotosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(660, 994);
            this.Controls.Add(this.AlbumDescriptionData);
            this.Controls.Add(this.AlbumDescriptionLabel);
            this.Controls.Add(this.AlbumLocationData);
            this.Controls.Add(this.AlbumLocationLabel);
            this.Controls.Add(this.AlbumTagsListBox);
            this.Controls.Add(this.AlbumTagsLabel);
            this.Controls.Add(this.NumAlbumLikesLabel);
            this.Controls.Add(this.AlbumLikesLabel);
            this.Controls.Add(this.AlbumPhotosListView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AlbumPhotosForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PhotosListView AlbumPhotosListView;
        private System.Windows.Forms.Label AlbumLikesLabel;
        private System.Windows.Forms.Label NumAlbumLikesLabel;
        private System.Windows.Forms.Label AlbumTagsLabel;
        private System.Windows.Forms.ListBox AlbumTagsListBox;
        private System.Windows.Forms.Label AlbumLocationLabel;
        private System.Windows.Forms.Label AlbumLocationData;
        private System.Windows.Forms.Label AlbumDescriptionLabel;
        private System.Windows.Forms.Label AlbumDescriptionData;
    }
}