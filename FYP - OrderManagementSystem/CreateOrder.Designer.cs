namespace FYP___OrderManagementSystem
{
    partial class CreateOrder
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
            this.SOButton = new System.Windows.Forms.Button();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.PCLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddButton = new System.Windows.Forms.Button();
            this.ProductCodeComboBox = new System.Windows.Forms.ComboBox();
            this.QuantityUpDown = new System.Windows.Forms.NumericUpDown();
            this.CartLabel = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequesteeTextBox = new System.Windows.Forms.TextBox();
            this.DepLabel = new System.Windows.Forms.Label();
            this.ProdCodeLabel = new System.Windows.Forms.Label();
            this.DepComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // SOButton
            // 
            this.SOButton.Location = new System.Drawing.Point(499, 124);
            this.SOButton.Name = "SOButton";
            this.SOButton.Size = new System.Drawing.Size(78, 26);
            this.SOButton.TabIndex = 37;
            this.SOButton.Text = "Submit Order";
            this.SOButton.UseVisualStyleBackColor = true;
            this.SOButton.Click += new System.EventHandler(this.SOButton_Click);
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.BackColor = System.Drawing.Color.Transparent;
            this.QuantityLabel.Location = new System.Drawing.Point(42, 68);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(46, 13);
            this.QuantityLabel.TabIndex = 28;
            this.QuantityLabel.Text = "Quantity";
            // 
            // PCLabel
            // 
            this.PCLabel.AutoSize = true;
            this.PCLabel.BackColor = System.Drawing.Color.Transparent;
            this.PCLabel.Location = new System.Drawing.Point(43, 22);
            this.PCLabel.Name = "PCLabel";
            this.PCLabel.Size = new System.Drawing.Size(72, 13);
            this.PCLabel.TabIndex = 27;
            this.PCLabel.Text = "Product Code";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(201, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(243, 112);
            this.dataGridView1.TabIndex = 32;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Item Code";
            this.Column5.Name = "Column5";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Quantity";
            this.Column1.Name = "Column1";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(45, 124);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(70, 26);
            this.AddButton.TabIndex = 26;
            this.AddButton.Text = "Add to Cart";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ProductCodeComboBox
            // 
            this.ProductCodeComboBox.FormattingEnabled = true;
            this.ProductCodeComboBox.Location = new System.Drawing.Point(45, 37);
            this.ProductCodeComboBox.Name = "ProductCodeComboBox";
            this.ProductCodeComboBox.Size = new System.Drawing.Size(100, 21);
            this.ProductCodeComboBox.TabIndex = 38;
            // 
            // QuantityUpDown
            // 
            this.QuantityUpDown.Location = new System.Drawing.Point(45, 84);
            this.QuantityUpDown.Name = "QuantityUpDown";
            this.QuantityUpDown.Size = new System.Drawing.Size(43, 20);
            this.QuantityUpDown.TabIndex = 39;
            // 
            // CartLabel
            // 
            this.CartLabel.AutoSize = true;
            this.CartLabel.Location = new System.Drawing.Point(198, 22);
            this.CartLabel.Name = "CartLabel";
            this.CartLabel.Size = new System.Drawing.Size(26, 13);
            this.CartLabel.TabIndex = 40;
            this.CartLabel.Text = "Cart";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.dataGridViewTextBoxColumn2,
            this.Column6});
            this.dataGridView2.Location = new System.Drawing.Point(12, 179);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(576, 205);
            this.dataGridView2.TabIndex = 41;
            this.dataGridView2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView2_MouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Product Code";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Price";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Stock";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 60;
            // 
            // RequesteeTextBox
            // 
            this.RequesteeTextBox.Location = new System.Drawing.Point(488, 84);
            this.RequesteeTextBox.Name = "RequesteeTextBox";
            this.RequesteeTextBox.Size = new System.Drawing.Size(100, 20);
            this.RequesteeTextBox.TabIndex = 42;
            // 
            // DepLabel
            // 
            this.DepLabel.AutoSize = true;
            this.DepLabel.BackColor = System.Drawing.Color.Transparent;
            this.DepLabel.Location = new System.Drawing.Point(485, 22);
            this.DepLabel.Name = "DepLabel";
            this.DepLabel.Size = new System.Drawing.Size(62, 13);
            this.DepLabel.TabIndex = 44;
            this.DepLabel.Text = "Department";
            // 
            // ProdCodeLabel
            // 
            this.ProdCodeLabel.AutoSize = true;
            this.ProdCodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProdCodeLabel.Location = new System.Drawing.Point(485, 68);
            this.ProdCodeLabel.Name = "ProdCodeLabel";
            this.ProdCodeLabel.Size = new System.Drawing.Size(59, 13);
            this.ProdCodeLabel.TabIndex = 45;
            this.ProdCodeLabel.Text = "Requestee";
            // 
            // DepComboBox
            // 
            this.DepComboBox.FormattingEnabled = true;
            this.DepComboBox.Location = new System.Drawing.Point(488, 37);
            this.DepComboBox.Name = "DepComboBox";
            this.DepComboBox.Size = new System.Drawing.Size(100, 21);
            this.DepComboBox.TabIndex = 46;
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 396);
            this.Controls.Add(this.DepComboBox);
            this.Controls.Add(this.ProdCodeLabel);
            this.Controls.Add(this.DepLabel);
            this.Controls.Add(this.RequesteeTextBox);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.CartLabel);
            this.Controls.Add(this.QuantityUpDown);
            this.Controls.Add(this.ProductCodeComboBox);
            this.Controls.Add(this.SOButton);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.PCLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddButton);
            this.Name = "CreateOrder";
            this.Text = "CreateOrder";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateOrder_FormClosing);
            this.Load += new System.EventHandler(this.CreateOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        

        private System.Windows.Forms.Button SOButton;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label PCLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox ProductCodeComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.NumericUpDown QuantityUpDown;
        private System.Windows.Forms.Label CartLabel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox RequesteeTextBox;
        private System.Windows.Forms.Label DepLabel;
        private System.Windows.Forms.Label ProdCodeLabel;
        private System.Windows.Forms.ComboBox DepComboBox;
    }
}