namespace FBAppUI.Forms
{
    public partial class ImageForm
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
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.ImageCommentBox = new System.Windows.Forms.RichTextBox();
            this.ImageCommentLabel = new System.Windows.Forms.Label();
            this.LikePictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.commentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CommentsListBox = new System.Windows.Forms.ListBox();
            this.CommentsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LikePictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.Location = new System.Drawing.Point(22, 21);
            this.ImagePictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(488, 445);
            this.ImagePictureBox.TabIndex = 0;
            this.ImagePictureBox.TabStop = false;
            // 
            // ImageCommentBox
            // 
            this.ImageCommentBox.Location = new System.Drawing.Point(120, 492);
            this.ImageCommentBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ImageCommentBox.Name = "ImageCommentBox";
            this.ImageCommentBox.Size = new System.Drawing.Size(391, 77);
            this.ImageCommentBox.TabIndex = 2;
            this.ImageCommentBox.Text = string.Empty;
            this.ImageCommentBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.imageCommentBox_KeyPress);
            // 
            // ImageCommentLabel
            // 
            this.ImageCommentLabel.AutoSize = true;
            this.ImageCommentLabel.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageCommentLabel.Location = new System.Drawing.Point(27, 519);
            this.ImageCommentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ImageCommentLabel.Name = "ImageCommentLabel";
            this.ImageCommentLabel.Size = new System.Drawing.Size(75, 17);
            this.ImageCommentLabel.TabIndex = 3;
            this.ImageCommentLabel.Text = "Comment:";
            // 
            // LikePictureBox
            // 
            this.LikePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LikePictureBox.Location = new System.Drawing.Point(16, 410);
            this.LikePictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LikePictureBox.Name = "LikePictureBox";
            this.LikePictureBox.Size = new System.Drawing.Size(72, 64);
            this.LikePictureBox.TabIndex = 4;
            this.LikePictureBox.TabStop = false;
            this.LikePictureBox.DoubleClick += new System.EventHandler(this.likePictureBox_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CommentsLabel);
            this.panel1.Controls.Add(this.CommentsListBox);
            this.panel1.Location = new System.Drawing.Point(529, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 445);
            this.panel1.TabIndex = 5;
            // 
            // commentsBindingSource
            // 
            this.commentsBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Comment);
            // 
            // CommentsListBox
            // 
            this.CommentsListBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Document;
            this.CommentsListBox.DataSource = this.commentsBindingSource;
            this.CommentsListBox.DisplayMember = "Message";
            this.CommentsListBox.FormattingEnabled = true;
            this.CommentsListBox.Location = new System.Drawing.Point(15, 61);
            this.CommentsListBox.Name = "CommentsListBox";
            this.CommentsListBox.Size = new System.Drawing.Size(376, 368);
            this.CommentsListBox.TabIndex = 0;
            this.CommentsListBox.ValueMember = "Comments";
            // 
            // CommentsLabel
            // 
            this.CommentsLabel.AutoSize = true;
            this.CommentsLabel.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentsLabel.Location = new System.Drawing.Point(158, 25);
            this.CommentsLabel.Name = "CommentsLabel";
            this.CommentsLabel.Size = new System.Drawing.Size(84, 17);
            this.CommentsLabel.TabIndex = 1;
            this.CommentsLabel.Text = "Comments";
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(932, 576);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LikePictureBox);
            this.Controls.Add(this.ImageCommentLabel);
            this.Controls.Add(this.ImageCommentBox);
            this.Controls.Add(this.ImagePictureBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ImageForm";
            this.Text = "Image name";
            this.Load += new System.EventHandler(this.imageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LikePictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImagePictureBox;
        private System.Windows.Forms.RichTextBox ImageCommentBox;
        private System.Windows.Forms.Label ImageCommentLabel;
        private System.Windows.Forms.PictureBox LikePictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CommentsLabel;
        private System.Windows.Forms.ListBox CommentsListBox;
        private System.Windows.Forms.BindingSource commentsBindingSource;
    }
}