﻿namespace FYP___OrderManagementSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.enterButton = new System.Windows.Forms.Button();
            this.clearUNButton = new System.Windows.Forms.Button();
            this.unLabel = new System.Windows.Forms.Label();
            this.pwLabel = new System.Windows.Forms.Label();
            this.forgotPWLink = new System.Windows.Forms.LinkLabel();
            this.unTextBox = new System.Windows.Forms.TextBox();
            this.pwTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearPWButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.LimeGreen;
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enterButton.Location = new System.Drawing.Point(443, 266);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(115, 33);
            this.enterButton.TabIndex = 3;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // clearUNButton
            // 
            this.clearUNButton.Location = new System.Drawing.Point(519, 107);
            this.clearUNButton.Name = "clearUNButton";
            this.clearUNButton.Size = new System.Drawing.Size(39, 20);
            this.clearUNButton.TabIndex = 5;
            this.clearUNButton.Text = "Clear";
            this.clearUNButton.UseVisualStyleBackColor = true;
            this.clearUNButton.Click += new System.EventHandler(this.ClearUNButton_Click);
            // 
            // unLabel
            // 
            this.unLabel.AutoSize = true;
            this.unLabel.BackColor = System.Drawing.Color.Transparent;
            this.unLabel.ForeColor = System.Drawing.Color.White;
            this.unLabel.Location = new System.Drawing.Point(303, 91);
            this.unLabel.Name = "unLabel";
            this.unLabel.Size = new System.Drawing.Size(61, 13);
            this.unLabel.TabIndex = 2;
            this.unLabel.Text = "Username :";
            // 
            // pwLabel
            // 
            this.pwLabel.AutoSize = true;
            this.pwLabel.BackColor = System.Drawing.Color.Transparent;
            this.pwLabel.ForeColor = System.Drawing.Color.White;
            this.pwLabel.Location = new System.Drawing.Point(303, 144);
            this.pwLabel.Name = "pwLabel";
            this.pwLabel.Size = new System.Drawing.Size(59, 13);
            this.pwLabel.TabIndex = 3;
            this.pwLabel.Text = "Password :";
            // 
            // forgotPWLink
            // 
            this.forgotPWLink.AutoSize = true;
            this.forgotPWLink.BackColor = System.Drawing.Color.Transparent;
            this.forgotPWLink.ForeColor = System.Drawing.Color.Yellow;
            this.forgotPWLink.LinkColor = System.Drawing.Color.Goldenrod;
            this.forgotPWLink.Location = new System.Drawing.Point(421, 192);
            this.forgotPWLink.Name = "forgotPWLink";
            this.forgotPWLink.Size = new System.Drawing.Size(92, 13);
            this.forgotPWLink.TabIndex = 7;
            this.forgotPWLink.TabStop = true;
            this.forgotPWLink.Text = "Forgot Password?";
            // 
            // unTextBox
            // 
            this.unTextBox.Location = new System.Drawing.Point(306, 107);
            this.unTextBox.Name = "unTextBox";
            this.unTextBox.Size = new System.Drawing.Size(207, 20);
            this.unTextBox.TabIndex = 1;
            this.unTextBox.Text = "user1";
            // 
            // pwTextBox
            // 
            this.pwTextBox.Location = new System.Drawing.Point(306, 160);
            this.pwTextBox.Name = "pwTextBox";
            this.pwTextBox.PasswordChar = '*';
            this.pwTextBox.Size = new System.Drawing.Size(207, 20);
            this.pwTextBox.TabIndex = 2;
            this.pwTextBox.Text = "password";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Location = new System.Drawing.Point(306, 266);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(115, 33);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // clearPWButton
            // 
            this.clearPWButton.Location = new System.Drawing.Point(519, 160);
            this.clearPWButton.Name = "clearPWButton";
            this.clearPWButton.Size = new System.Drawing.Size(39, 20);
            this.clearPWButton.TabIndex = 6;
            this.clearPWButton.Text = "Clear";
            this.clearPWButton.UseVisualStyleBackColor = true;
            this.clearPWButton.Click += new System.EventHandler(this.ClearPWButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 340);
            this.Controls.Add(this.clearPWButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pwTextBox);
            this.Controls.Add(this.unTextBox);
            this.Controls.Add(this.forgotPWLink);
            this.Controls.Add(this.pwLabel);
            this.Controls.Add(this.unLabel);
            this.Controls.Add(this.clearUNButton);
            this.Controls.Add(this.enterButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button clearUNButton;
        private System.Windows.Forms.Label unLabel;
        private System.Windows.Forms.Label pwLabel;
        private System.Windows.Forms.LinkLabel forgotPWLink;
        private System.Windows.Forms.TextBox unTextBox;
        private System.Windows.Forms.TextBox pwTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearPWButton;
    }
}

