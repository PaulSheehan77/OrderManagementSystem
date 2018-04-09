namespace FYP___OrderManagementSystem
{
    partial class LogGRN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogGRN));
            this.panel2 = new System.Windows.Forms.Panel();
            this.PCComboBox = new System.Windows.Forms.ComboBox();
            this.PCLabel = new System.Windows.Forms.Label();
            this.QuantityUpDown = new System.Windows.Forms.NumericUpDown();
            this.OIDComboBox = new System.Windows.Forms.ComboBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.OIDLabel = new System.Windows.Forms.Label();
            this.LogItemButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.PCComboBox);
            this.panel2.Controls.Add(this.PCLabel);
            this.panel2.Controls.Add(this.QuantityUpDown);
            this.panel2.Controls.Add(this.OIDComboBox);
            this.panel2.Controls.Add(this.QuantityLabel);
            this.panel2.Controls.Add(this.OIDLabel);
            this.panel2.Controls.Add(this.LogItemButton);
            this.panel2.Location = new System.Drawing.Point(23, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 99);
            this.panel2.TabIndex = 46;
            // 
            // PCComboBox
            // 
            this.PCComboBox.FormattingEnabled = true;
            this.PCComboBox.Location = new System.Drawing.Point(160, 30);
            this.PCComboBox.Name = "PCComboBox";
            this.PCComboBox.Size = new System.Drawing.Size(100, 21);
            this.PCComboBox.TabIndex = 43;
            this.PCComboBox.SelectedIndexChanged += new System.EventHandler(this.PCComboBox_SelectedIndexChanged);
            // 
            // PCLabel
            // 
            this.PCLabel.AutoSize = true;
            this.PCLabel.BackColor = System.Drawing.Color.Transparent;
            this.PCLabel.Location = new System.Drawing.Point(157, 14);
            this.PCLabel.Name = "PCLabel";
            this.PCLabel.Size = new System.Drawing.Size(72, 13);
            this.PCLabel.TabIndex = 44;
            this.PCLabel.Text = "Product Code";
            // 
            // QuantityUpDown
            // 
            this.QuantityUpDown.Location = new System.Drawing.Point(319, 30);
            this.QuantityUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantityUpDown.Name = "QuantityUpDown";
            this.QuantityUpDown.Size = new System.Drawing.Size(43, 20);
            this.QuantityUpDown.TabIndex = 1;
            this.QuantityUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // OIDComboBox
            // 
            this.OIDComboBox.FormattingEnabled = true;
            this.OIDComboBox.Location = new System.Drawing.Point(14, 30);
            this.OIDComboBox.Name = "OIDComboBox";
            this.OIDComboBox.Size = new System.Drawing.Size(100, 21);
            this.OIDComboBox.TabIndex = 0;
            this.OIDComboBox.SelectedIndexChanged += new System.EventHandler(this.OIDComboBox_SelectedIndexChanged);
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.BackColor = System.Drawing.Color.Transparent;
            this.QuantityLabel.Location = new System.Drawing.Point(316, 14);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(46, 13);
            this.QuantityLabel.TabIndex = 42;
            this.QuantityLabel.Text = "Quantity";
            // 
            // OIDLabel
            // 
            this.OIDLabel.AutoSize = true;
            this.OIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.OIDLabel.Location = new System.Drawing.Point(11, 14);
            this.OIDLabel.Name = "OIDLabel";
            this.OIDLabel.Size = new System.Drawing.Size(44, 13);
            this.OIDLabel.TabIndex = 41;
            this.OIDLabel.Text = "OrderID";
            // 
            // LogItemButton
            // 
            this.LogItemButton.Location = new System.Drawing.Point(160, 73);
            this.LogItemButton.Name = "LogItemButton";
            this.LogItemButton.Size = new System.Drawing.Size(70, 26);
            this.LogItemButton.TabIndex = 2;
            this.LogItemButton.Text = "Log Item";
            this.LogItemButton.UseVisualStyleBackColor = true;
            this.LogItemButton.Click += new System.EventHandler(this.LogItemButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.dataGridViewTextBoxColumn1,
            this.Column6});
            this.dataGridView2.Location = new System.Drawing.Point(23, 129);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(398, 250);
            this.dataGridView2.TabIndex = 44;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "OrderID";
            this.Column2.Name = "Column2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Product Code";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Quantity";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RefreshButton.Location = new System.Drawing.Point(202, 385);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(58, 23);
            this.RefreshButton.TabIndex = 47;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // LogGRN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(450, 417);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogGRN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log GRN";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown QuantityUpDown;
        private System.Windows.Forms.ComboBox OIDComboBox;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label OIDLabel;
        private System.Windows.Forms.Button LogItemButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox PCComboBox;
        private System.Windows.Forms.Label PCLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button RefreshButton;
    }
}