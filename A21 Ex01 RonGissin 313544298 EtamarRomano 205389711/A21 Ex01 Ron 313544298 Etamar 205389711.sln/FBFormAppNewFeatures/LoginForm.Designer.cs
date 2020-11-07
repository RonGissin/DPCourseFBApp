namespace FBFormAppNewFeatures
{
    partial class LoginForm
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
            this.ConnnectWithFacebookButton = new System.Windows.Forms.Button();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConnnectWithFacebookButton
            // 
            this.ConnnectWithFacebookButton.BackColor = System.Drawing.Color.Blue;
            this.ConnnectWithFacebookButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ConnnectWithFacebookButton.Location = new System.Drawing.Point(141, 269);
            this.ConnnectWithFacebookButton.Name = "ConnnectWithFacebookButton";
            this.ConnnectWithFacebookButton.Size = new System.Drawing.Size(520, 58);
            this.ConnnectWithFacebookButton.TabIndex = 0;
            this.ConnnectWithFacebookButton.Text = "Login with Facebook";
            this.ConnnectWithFacebookButton.UseVisualStyleBackColor = false;
            this.ConnnectWithFacebookButton.Click += new System.EventHandler(this.LoginWithFacebookButton_Click);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Location = new System.Drawing.Point(194, 81);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(416, 32);
            this.WelcomeLabel.TabIndex = 1;
            this.WelcomeLabel.Text = "Welcome to the Facebook App !";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.ConnnectWithFacebookButton);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnnectWithFacebookButton;
        private System.Windows.Forms.Label WelcomeLabel;
    }
}

