namespace FYP___OrderManagementSystem
{
    partial class NewAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAccount));
            this.CAButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SNTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FNTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ALcb = new System.Windows.Forms.ComboBox();
            this.DEPcb = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CAButton
            // 
            this.CAButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CAButton.Location = new System.Drawing.Point(49, 218);
            this.CAButton.Name = "CAButton";
            this.CAButton.Size = new System.Drawing.Size(153, 23);
            this.CAButton.TabIndex = 5;
            this.CAButton.Text = "Create Account!";
            this.CAButton.UseVisualStyleBackColor = true;
            this.CAButton.Click += new System.EventHandler(this.CAButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.ALcb);
            this.panel1.Controls.Add(this.DEPcb);
            this.panel1.Controls.Add(this.CAButton);
            this.panel1.Controls.Add(this.SNTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.FNTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 269);
            this.panel1.TabIndex = 7;
            // 
            // SNTextBox
            // 
            this.SNTextBox.Location = new System.Drawing.Point(116, 68);
            this.SNTextBox.Name = "SNTextBox";
            this.SNTextBox.Size = new System.Drawing.Size(100, 20);
            this.SNTextBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Access Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Department";
            // 
            // FNTextBox
            // 
            this.FNTextBox.Location = new System.Drawing.Point(116, 24);
            this.FNTextBox.Name = "FNTextBox";
            this.FNTextBox.Size = new System.Drawing.Size(100, 20);
            this.FNTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Forename";
            // 
            // ALcb
            // 
            this.ALcb.FormattingEnabled = true;
            this.ALcb.Location = new System.Drawing.Point(116, 166);
            this.ALcb.Name = "ALcb";
            this.ALcb.Size = new System.Drawing.Size(53, 21);
            this.ALcb.TabIndex = 67;
            // 
            // DEPcb
            // 
            this.DEPcb.FormattingEnabled = true;
            this.DEPcb.Location = new System.Drawing.Point(116, 114);
            this.DEPcb.Name = "DEPcb";
            this.DEPcb.Size = new System.Drawing.Size(100, 21);
            this.DEPcb.TabIndex = 66;
            // 
            // NewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(277, 332);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Account";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CAButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox SNTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FNTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ALcb;
        private System.Windows.Forms.ComboBox DEPcb;
    }
}