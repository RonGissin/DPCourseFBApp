namespace FBAppUI.Forms
{
    partial class ImageForm
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
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.ImageCommentBox = new System.Windows.Forms.RichTextBox();
            this.ImageCommentLabel = new System.Windows.Forms.Label();
            this.LikePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LikePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.Location = new System.Drawing.Point(33, 32);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(732, 685);
            this.ImagePictureBox.TabIndex = 0;
            this.ImagePictureBox.TabStop = false;
            // 
            // ImageCommentBox
            // 
            this.ImageCommentBox.Location = new System.Drawing.Point(180, 757);
            this.ImageCommentBox.Name = "ImageCommentBox";
            this.ImageCommentBox.Size = new System.Drawing.Size(585, 116);
            this.ImageCommentBox.TabIndex = 2;
            this.ImageCommentBox.Text = "";
            this.ImageCommentBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ImageCommentBox_KeyPress);
            // 
            // ImageCommentLabel
            // 
            this.ImageCommentLabel.AutoSize = true;
            this.ImageCommentLabel.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageCommentLabel.Location = new System.Drawing.Point(41, 799);
            this.ImageCommentLabel.Name = "ImageCommentLabel";
            this.ImageCommentLabel.Size = new System.Drawing.Size(104, 22);
            this.ImageCommentLabel.TabIndex = 3;
            this.ImageCommentLabel.Text = "Comment:";
            // 
            // LikePictureBox
            // 
            this.LikePictureBox.Location = new System.Drawing.Point(24, 631);
            this.LikePictureBox.Name = "LikePictureBox";
            this.LikePictureBox.Size = new System.Drawing.Size(108, 98);
            this.LikePictureBox.TabIndex = 4;
            this.LikePictureBox.TabStop = false;
            this.LikePictureBox.DoubleClick += new System.EventHandler(this.LikePictureBox_DoubleClick);
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 903);
            this.Controls.Add(this.LikePictureBox);
            this.Controls.Add(this.ImageCommentLabel);
            this.Controls.Add(this.ImageCommentBox);
            this.Controls.Add(this.ImagePictureBox);
            this.Name = "ImageForm";
            this.Text = "Image name";
            this.Load += new System.EventHandler(this.ImageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LikePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImagePictureBox;
        private System.Windows.Forms.RichTextBox ImageCommentBox;
        private System.Windows.Forms.Label ImageCommentLabel;
        private System.Windows.Forms.PictureBox LikePictureBox;
    }
}