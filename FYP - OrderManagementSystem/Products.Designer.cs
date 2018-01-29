namespace FYP___OrderManagementSystem
{
    partial class Products
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
            this.PCTextBox = new System.Windows.Forms.TextBox();
            this.PNTextBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCLabel = new System.Windows.Forms.Label();
            this.PNLabel = new System.Windows.Forms.Label();
            this.SCLabel = new System.Windows.Forms.Label();
            this.SNLabel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SCTextBox = new System.Windows.Forms.TextBox();
            this.SNTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.StockLabel = new System.Windows.Forms.Label();
            this.StockTextBox = new System.Windows.Forms.TextBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PCTextBox
            // 
            this.PCTextBox.Location = new System.Drawing.Point(36, 44);
            this.PCTextBox.Name = "PCTextBox";
            this.PCTextBox.Size = new System.Drawing.Size(100, 20);
            this.PCTextBox.TabIndex = 0;
            // 
            // PNTextBox
            // 
            this.PNTextBox.Location = new System.Drawing.Point(211, 45);
            this.PNTextBox.Name = "PNTextBox";
            this.PNTextBox.Size = new System.Drawing.Size(100, 20);
            this.PNTextBox.TabIndex = 1;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(630, 78);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(88, 34);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(526, 31);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(88, 33);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(36, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(688, 277);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView1_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product Code";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Product Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Supplier Name";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Supplier Code";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Price";
            this.Column5.Name = "Column5";
            this.Column5.Width = 60;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Stock";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 60;
            // 
            // PCLabel
            // 
            this.PCLabel.AutoSize = true;
            this.PCLabel.BackColor = System.Drawing.Color.Transparent;
            this.PCLabel.Location = new System.Drawing.Point(33, 28);
            this.PCLabel.Name = "PCLabel";
            this.PCLabel.Size = new System.Drawing.Size(72, 13);
            this.PCLabel.TabIndex = 6;
            this.PCLabel.Text = "Product Code";
            // 
            // PNLabel
            // 
            this.PNLabel.AutoSize = true;
            this.PNLabel.BackColor = System.Drawing.Color.Transparent;
            this.PNLabel.Location = new System.Drawing.Point(208, 28);
            this.PNLabel.Name = "PNLabel";
            this.PNLabel.Size = new System.Drawing.Size(75, 13);
            this.PNLabel.TabIndex = 7;
            this.PNLabel.Text = "Product Name";
            // 
            // SCLabel
            // 
            this.SCLabel.AutoSize = true;
            this.SCLabel.BackColor = System.Drawing.Color.Transparent;
            this.SCLabel.Location = new System.Drawing.Point(208, 76);
            this.SCLabel.Name = "SCLabel";
            this.SCLabel.Size = new System.Drawing.Size(73, 13);
            this.SCLabel.TabIndex = 15;
            this.SCLabel.Text = "Supplier Code";
            // 
            // SNLabel
            // 
            this.SNLabel.AutoSize = true;
            this.SNLabel.BackColor = System.Drawing.Color.Transparent;
            this.SNLabel.Location = new System.Drawing.Point(33, 76);
            this.SNLabel.Name = "SNLabel";
            this.SNLabel.Size = new System.Drawing.Size(76, 13);
            this.SNLabel.TabIndex = 14;
            this.SNLabel.Text = "Supplier Name";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(630, 31);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(88, 33);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // SCTextBox
            // 
            this.SCTextBox.Location = new System.Drawing.Point(211, 93);
            this.SCTextBox.Name = "SCTextBox";
            this.SCTextBox.Size = new System.Drawing.Size(100, 20);
            this.SCTextBox.TabIndex = 4;
            // 
            // SNTextBox
            // 
            this.SNTextBox.Location = new System.Drawing.Point(36, 92);
            this.SNTextBox.Name = "SNTextBox";
            this.SNTextBox.Size = new System.Drawing.Size(100, 20);
            this.SNTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(378, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Price";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(381, 45);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriceTextBox.TabIndex = 2;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(526, 79);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(88, 33);
            this.FindButton.TabIndex = 8;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // StockLabel
            // 
            this.StockLabel.AutoSize = true;
            this.StockLabel.BackColor = System.Drawing.Color.Transparent;
            this.StockLabel.Location = new System.Drawing.Point(378, 76);
            this.StockLabel.Name = "StockLabel";
            this.StockLabel.Size = new System.Drawing.Size(35, 13);
            this.StockLabel.TabIndex = 18;
            this.StockLabel.Text = "Stock";
            // 
            // StockTextBox
            // 
            this.StockTextBox.Location = new System.Drawing.Point(381, 93);
            this.StockTextBox.Name = "StockTextBox";
            this.StockTextBox.Size = new System.Drawing.Size(100, 20);
            this.StockTextBox.TabIndex = 5;
            this.StockTextBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(666, 428);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(58, 26);
            this.RefreshButton.TabIndex = 19;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 466);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.StockLabel);
            this.Controls.Add(this.StockTextBox);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SCLabel);
            this.Controls.Add(this.SNLabel);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SCTextBox);
            this.Controls.Add(this.SNTextBox);
            this.Controls.Add(this.PNLabel);
            this.Controls.Add(this.PCLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.PNTextBox);
            this.Controls.Add(this.PCTextBox);
            this.Location = new System.Drawing.Point(32, 72);
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Products";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PCTextBox;
        private System.Windows.Forms.TextBox PNTextBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label PCLabel;
        private System.Windows.Forms.Label PNLabel;
        private System.Windows.Forms.Label SCLabel;
        private System.Windows.Forms.Label SNLabel;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox SCTextBox;
        private System.Windows.Forms.TextBox SNTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Label StockLabel;
        private System.Windows.Forms.TextBox StockTextBox;
        private System.Windows.Forms.Button RefreshButton;
    }
}