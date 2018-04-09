namespace FYP___OrderManagementSystem
{
    partial class OrderManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderManagement));
            this.OrderIDComboBox = new System.Windows.Forms.ComboBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.OrderStatusLabel = new System.Windows.Forms.Label();
            this.OrderStatusComboBox = new System.Windows.Forms.ComboBox();
            this.OCLabel = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderIDComboBox
            // 
            this.OrderIDComboBox.FormattingEnabled = true;
            this.OrderIDComboBox.Location = new System.Drawing.Point(93, 42);
            this.OrderIDComboBox.Name = "OrderIDComboBox";
            this.OrderIDComboBox.Size = new System.Drawing.Size(100, 21);
            this.OrderIDComboBox.TabIndex = 0;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(392, 38);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(70, 26);
            this.UpdateButton.TabIndex = 2;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
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
            this.dataGridViewTextBoxColumn1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.dataGridViewTextBoxColumn2,
            this.Column6,
            this.Column1});
            this.dataGridView2.Location = new System.Drawing.Point(21, 102);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(720, 203);
            this.dataGridView2.TabIndex = 44;
            this.dataGridView2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView2_MouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.FillWeight = 80F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Order ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 30F;
            this.Column2.HeaderText = "# of Items";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.FillWeight = 70F;
            this.Column3.HeaderText = "Department";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Requested by";
            this.Column4.Name = "Column4";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Order Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.FillWeight = 110F;
            this.Column6.HeaderText = "Order Status";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 60F;
            this.Column1.HeaderText = "Order Total";
            this.Column1.Name = "Column1";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.OrderStatusLabel);
            this.panel2.Controls.Add(this.OrderStatusComboBox);
            this.panel2.Controls.Add(this.OrderIDComboBox);
            this.panel2.Controls.Add(this.OCLabel);
            this.panel2.Controls.Add(this.UpdateButton);
            this.panel2.Location = new System.Drawing.Point(98, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 66);
            this.panel2.TabIndex = 46;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(515, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // OrderStatusLabel
            // 
            this.OrderStatusLabel.AutoSize = true;
            this.OrderStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.OrderStatusLabel.Location = new System.Drawing.Point(243, 26);
            this.OrderStatusLabel.Name = "OrderStatusLabel";
            this.OrderStatusLabel.Size = new System.Drawing.Size(66, 13);
            this.OrderStatusLabel.TabIndex = 43;
            this.OrderStatusLabel.Text = "Order Status";
            // 
            // OrderStatusComboBox
            // 
            this.OrderStatusComboBox.FormattingEnabled = true;
            this.OrderStatusComboBox.Location = new System.Drawing.Point(246, 42);
            this.OrderStatusComboBox.Name = "OrderStatusComboBox";
            this.OrderStatusComboBox.Size = new System.Drawing.Size(103, 21);
            this.OrderStatusComboBox.TabIndex = 42;
            // 
            // OCLabel
            // 
            this.OCLabel.AutoSize = true;
            this.OCLabel.BackColor = System.Drawing.Color.Transparent;
            this.OCLabel.Location = new System.Drawing.Point(90, 26);
            this.OCLabel.Name = "OCLabel";
            this.OCLabel.Size = new System.Drawing.Size(47, 13);
            this.OCLabel.TabIndex = 41;
            this.OCLabel.Text = "Order ID";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RefreshButton.Location = new System.Drawing.Point(371, 320);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(58, 26);
            this.RefreshButton.TabIndex = 47;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // OrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(772, 367);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(410, 15);
            this.Name = "OrderManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox OrderIDComboBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label OCLabel;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Label OrderStatusLabel;
        private System.Windows.Forms.ComboBox OrderStatusComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}