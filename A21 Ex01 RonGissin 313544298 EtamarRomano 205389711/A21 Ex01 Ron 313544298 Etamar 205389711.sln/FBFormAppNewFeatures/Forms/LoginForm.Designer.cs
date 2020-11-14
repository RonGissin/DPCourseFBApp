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
            this.ConnnectWithFacebookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConnnectWithFacebookButton.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnnectWithFacebookButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ConnnectWithFacebookButton.Location = new System.Drawing.Point(79, 174);
            this.ConnnectWithFacebookButton.Margin = new System.Windows.Forms.Padding(2);
            this.ConnnectWithFacebookButton.Name = "ConnnectWithFacebookButton";
            this.ConnnectWithFacebookButton.Size = new System.Drawing.Size(292, 37);
            this.ConnnectWithFacebookButton.TabIndex = 0;
            this.ConnnectWithFacebookButton.Text = "Login with Facebook";
            this.ConnnectWithFacebookButton.UseVisualStyleBackColor = false;
            this.ConnnectWithFacebookButton.Click += new System.EventHandler(this.LoginWithFacebookButton_Click);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WelcomeLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(11, 76);
            this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(441, 29);
            this.WelcomeLabel.TabIndex = 1;
            this.WelcomeLabel.Text = "Welcome to Facebook Pics Explorer";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(450, 290);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.ConnnectWithFacebookButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnnectWithFacebookButton;
        private System.Windows.Forms.Label WelcomeLabel;
    }
}

