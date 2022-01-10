namespace MagazinEF {
    partial class MagazinForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MagazinForm));
            this.iconLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLoginUser = new System.Windows.Forms.Button();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // iconLabel
            // 
            this.iconLabel.AutoSize = true;
            this.iconLabel.Location = new System.Drawing.Point(334, 259);
            this.iconLabel.Name = "iconLabel";
            this.iconLabel.Size = new System.Drawing.Size(0, 16);
            this.iconLabel.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::MagazinEF.Properties.Resources.market_analysis_icon;
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(268, 36);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(222, 178);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.ForeColor = System.Drawing.Color.Magenta;
            this.labelUsername.Location = new System.Drawing.Point(241, 258);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(70, 16);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.ForeColor = System.Drawing.Color.Magenta;
            this.labelPassword.Location = new System.Drawing.Point(241, 305);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(67, 16);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Password";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(317, 255);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(172, 22);
            this.textBoxUsername.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(317, 302);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(172, 22);
            this.textBoxPassword.TabIndex = 6;
            // 
            // buttonLoginUser
            // 
            this.buttonLoginUser.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonLoginUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLoginUser.Location = new System.Drawing.Point(337, 335);
            this.buttonLoginUser.Name = "buttonLoginUser";
            this.buttonLoginUser.Size = new System.Drawing.Size(105, 37);
            this.buttonLoginUser.TabIndex = 7;
            this.buttonLoginUser.Text = "Login";
            this.buttonLoginUser.UseVisualStyleBackColor = false;
            this.buttonLoginUser.Click += new System.EventHandler(this.buttonLoginUser_Click);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.ForeColor = System.Drawing.Color.Fuchsia;
            this.buttonSignUp.Location = new System.Drawing.Point(268, 401);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(90, 28);
            this.buttonSignUp.TabIndex = 8;
            this.buttonSignUp.Text = "SignUp";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdmin.ForeColor = System.Drawing.Color.Fuchsia;
            this.buttonAdmin.Location = new System.Drawing.Point(683, 401);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(105, 37);
            this.buttonAdmin.TabIndex = 9;
            this.buttonAdmin.Text = "AdminLogin";
            this.buttonAdmin.UseVisualStyleBackColor = false;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // MagazinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.buttonLoginUser);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.iconLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MagazinForm";
            this.Text = "MyMagazin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label iconLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLoginUser;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Button buttonAdmin;
    }
}

