﻿namespace itHappens.UIs.anna
{
    partial class LogInPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginButton = new System.Windows.Forms.Button();
            this.createAccountLabel = new System.Windows.Forms.LinkLabel();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.itHappensLabel = new System.Windows.Forms.Label();
            this.UserPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoginButton.BackColor = System.Drawing.Color.DarkOrange;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.LoginButton.Location = new System.Drawing.Point(93, 448);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(292, 46);
            this.LoginButton.TabIndex = 14;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // createAccountLabel
            // 
            this.createAccountLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.createAccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.createAccountLabel.LinkColor = System.Drawing.Color.DarkOrange;
            this.createAccountLabel.Location = new System.Drawing.Point(94, 583);
            this.createAccountLabel.Name = "createAccountLabel";
            this.createAccountLabel.Size = new System.Drawing.Size(292, 23);
            this.createAccountLabel.TabIndex = 13;
            this.createAccountLabel.TabStop = true;
            this.createAccountLabel.Text = "Create new account";
            this.createAccountLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.createAccountLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createAccountLabel_LinkClicked_1);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PasswordTextBox.BackColor = System.Drawing.Color.LightGray;
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PasswordTextBox.Location = new System.Drawing.Point(93, 359);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(291, 26);
            this.PasswordTextBox.TabIndex = 12;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordTextBox_KeyPress);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UsernameTextBox.BackColor = System.Drawing.Color.LightGray;
            this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.UsernameTextBox.Location = new System.Drawing.Point(93, 264);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(291, 26);
            this.UsernameTextBox.TabIndex = 11;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.PasswordLabel.Location = new System.Drawing.Point(93, 323);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(97, 24);
            this.PasswordLabel.TabIndex = 10;
            this.PasswordLabel.Text = "Password:";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.UsernameLabel.Location = new System.Drawing.Point(93, 229);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(102, 24);
            this.UsernameLabel.TabIndex = 9;
            this.UsernameLabel.Text = "Username:";
            // 
            // itHappensLabel
            // 
            this.itHappensLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.itHappensLabel.BackColor = System.Drawing.Color.Transparent;
            this.itHappensLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.itHappensLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.itHappensLabel.Location = new System.Drawing.Point(138, 11);
            this.itHappensLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.itHappensLabel.Name = "itHappensLabel";
            this.itHappensLabel.Size = new System.Drawing.Size(213, 58);
            this.itHappensLabel.TabIndex = 43;
            this.itHappensLabel.Text = "LOGIN";
            this.itHappensLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserPictureBox
            // 
            this.UserPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.UserPictureBox.BackgroundImage = global::itHappens.Properties.Resources.Logo_dark;
            this.UserPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UserPictureBox.Location = new System.Drawing.Point(162, 73);
            this.UserPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserPictureBox.Name = "UserPictureBox";
            this.UserPictureBox.Size = new System.Drawing.Size(172, 147);
            this.UserPictureBox.TabIndex = 15;
            this.UserPictureBox.TabStop = false;
            // 
            // LogInPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.itHappensLabel);
            this.Controls.Add(this.UserPictureBox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.createAccountLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LogInPage";
            this.Size = new System.Drawing.Size(489, 664);
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox UserPictureBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.LinkLabel createAccountLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label itHappensLabel;
        public System.Windows.Forms.TextBox PasswordTextBox;
        public System.Windows.Forms.TextBox UsernameTextBox;
    }
}
