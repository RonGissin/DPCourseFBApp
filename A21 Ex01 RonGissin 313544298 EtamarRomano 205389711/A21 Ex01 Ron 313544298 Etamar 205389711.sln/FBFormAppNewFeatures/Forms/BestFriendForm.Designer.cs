namespace FBFormAppNewFeatures.Forms
{
    partial class BestFriendForm
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
            this.BestFriendPictureBox = new System.Windows.Forms.PictureBox();
            this.BestFriendFormLabel = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BestFriendPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BestFriendPictureBox
            // 
            this.BestFriendPictureBox.Location = new System.Drawing.Point(179, 154);
            this.BestFriendPictureBox.Name = "BestFriendPictureBox";
            this.BestFriendPictureBox.Size = new System.Drawing.Size(201, 196);
            this.BestFriendPictureBox.TabIndex = 0;
            this.BestFriendPictureBox.TabStop = false;
            // 
            // BestFriendFormLabel
            // 
            this.BestFriendFormLabel.AutoSize = true;
            this.BestFriendFormLabel.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BestFriendFormLabel.Location = new System.Drawing.Point(171, 411);
            this.BestFriendFormLabel.Name = "BestFriendFormLabel";
            this.BestFriendFormLabel.Size = new System.Drawing.Size(221, 46);
            this.BestFriendFormLabel.TabIndex = 1;
            this.BestFriendFormLabel.Text = "best friend";
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.Location = new System.Drawing.Point(95, 62);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(360, 46);
            this.HeaderLabel.TabIndex = 2;
            this.HeaderLabel.Text = "Your best friend is";
            // 
            // BestFriendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(574, 534);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.BestFriendFormLabel);
            this.Controls.Add(this.BestFriendPictureBox);
            this.Name = "BestFriendForm";
            this.Text = "Your Best Friend";
            ((System.ComponentModel.ISupportInitialize)(this.BestFriendPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BestFriendPictureBox;
        private System.Windows.Forms.Label BestFriendFormLabel;
        private System.Windows.Forms.Label HeaderLabel;
    }
}