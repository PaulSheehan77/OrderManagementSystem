namespace FYP___OrderManagementSystem
{
    partial class ExistingAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExistingAccount));
            this.RefreshButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ALcb = new System.Windows.Forms.ComboBox();
            this.DEPcb = new System.Windows.Forms.ComboBox();
            this.UNcb = new System.Windows.Forms.ComboBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SNLabel = new System.Windows.Forms.Label();
            this.SNULabel = new System.Windows.Forms.Label();
            this.SALabel = new System.Windows.Forms.Label();
            this.PWTextBox = new System.Windows.Forms.TextBox();
            this.StockLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshButton.Location = new System.Drawing.Point(175, 423);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(58, 26);
            this.RefreshButton.TabIndex = 24;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(13, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(373, 201);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView1_MouseDoubleClick);
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Username";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Department";
            this.Column4.Name = "Column4";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "Access Level";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Password";
            this.Column2.Name = "Column2";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.ALcb);
            this.panel1.Controls.Add(this.DEPcb);
            this.panel1.Controls.Add(this.UNcb);
            this.panel1.Controls.Add(this.UpdateButton);
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.SNLabel);
            this.panel1.Controls.Add(this.SNULabel);
            this.panel1.Controls.Add(this.SALabel);
            this.panel1.Controls.Add(this.PWTextBox);
            this.panel1.Controls.Add(this.StockLabel);
            this.panel1.Location = new System.Drawing.Point(13, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 170);
            this.panel1.TabIndex = 28;
            // 
            // ALcb
            // 
            this.ALcb.FormattingEnabled = true;
            this.ALcb.Location = new System.Drawing.Point(136, 86);
            this.ALcb.Name = "ALcb";
            this.ALcb.Size = new System.Drawing.Size(94, 21);
            this.ALcb.TabIndex = 45;
            // 
            // DEPcb
            // 
            this.DEPcb.FormattingEnabled = true;
            this.DEPcb.Location = new System.Drawing.Point(136, 59);
            this.DEPcb.Name = "DEPcb";
            this.DEPcb.Size = new System.Drawing.Size(94, 21);
            this.DEPcb.TabIndex = 44;
            // 
            // UNcb
            // 
            this.UNcb.FormattingEnabled = true;
            this.UNcb.Location = new System.Drawing.Point(136, 33);
            this.UNcb.Name = "UNcb";
            this.UNcb.Size = new System.Drawing.Size(126, 21);
            this.UNcb.TabIndex = 43;
            this.UNcb.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpdateButton.Location = new System.Drawing.Point(281, 80);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(74, 22);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteButton.Location = new System.Drawing.Point(281, 110);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(74, 23);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SNLabel
            // 
            this.SNLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SNLabel.AutoSize = true;
            this.SNLabel.BackColor = System.Drawing.Color.Transparent;
            this.SNLabel.Location = new System.Drawing.Point(75, 36);
            this.SNLabel.Name = "SNLabel";
            this.SNLabel.Size = new System.Drawing.Size(55, 13);
            this.SNLabel.TabIndex = 41;
            this.SNLabel.Text = "Username";
            // 
            // SNULabel
            // 
            this.SNULabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SNULabel.AutoSize = true;
            this.SNULabel.BackColor = System.Drawing.Color.Transparent;
            this.SNULabel.Location = new System.Drawing.Point(59, 89);
            this.SNULabel.Name = "SNULabel";
            this.SNULabel.Size = new System.Drawing.Size(71, 13);
            this.SNULabel.TabIndex = 42;
            this.SNULabel.Text = "Access Level";
            // 
            // SALabel
            // 
            this.SALabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SALabel.AutoSize = true;
            this.SALabel.BackColor = System.Drawing.Color.Transparent;
            this.SALabel.Location = new System.Drawing.Point(68, 64);
            this.SALabel.Name = "SALabel";
            this.SALabel.Size = new System.Drawing.Size(62, 13);
            this.SALabel.TabIndex = 40;
            this.SALabel.Text = "Department";
            // 
            // PWTextBox
            // 
            this.PWTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PWTextBox.Location = new System.Drawing.Point(136, 113);
            this.PWTextBox.Name = "PWTextBox";
            this.PWTextBox.Size = new System.Drawing.Size(94, 20);
            this.PWTextBox.TabIndex = 5;
            // 
            // StockLabel
            // 
            this.StockLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StockLabel.AutoSize = true;
            this.StockLabel.BackColor = System.Drawing.Color.Transparent;
            this.StockLabel.Location = new System.Drawing.Point(75, 116);
            this.StockLabel.Name = "StockLabel";
            this.StockLabel.Size = new System.Drawing.Size(53, 13);
            this.StockLabel.TabIndex = 26;
            this.StockLabel.Text = "Password";
            // 
            // ExistingAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 465);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RefreshButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExistingAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Existing Account";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label SNLabel;
        private System.Windows.Forms.Label SNULabel;
        private System.Windows.Forms.Label SALabel;
        private System.Windows.Forms.TextBox PWTextBox;
        private System.Windows.Forms.Label StockLabel;
        private System.Windows.Forms.ComboBox ALcb;
        private System.Windows.Forms.ComboBox DEPcb;
        private System.Windows.Forms.ComboBox UNcb;
    }
}