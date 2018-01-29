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
            this.AddButton = new System.Windows.Forms.Button();
            this.ProductCodeComboBox = new System.Windows.Forms.ComboBox();
            this.QuantityUpDown = new System.Windows.Forms.NumericUpDown();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SOButton
            // 
            this.SOButton.Location = new System.Drawing.Point(436, 361);
            this.SOButton.Name = "SOButton";
            this.SOButton.Size = new System.Drawing.Size(79, 26);
            this.SOButton.TabIndex = 37;
            this.SOButton.Text = "Submit Order";
            this.SOButton.UseVisualStyleBackColor = true;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.BackColor = System.Drawing.Color.Transparent;
            this.QuantityLabel.Location = new System.Drawing.Point(177, 155);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(46, 13);
            this.QuantityLabel.TabIndex = 28;
            this.QuantityLabel.Text = "Quantity";
            // 
            // PCLabel
            // 
            this.PCLabel.AutoSize = true;
            this.PCLabel.BackColor = System.Drawing.Color.Transparent;
            this.PCLabel.Location = new System.Drawing.Point(45, 153);
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
            this.dataGridView1.Location = new System.Drawing.Point(272, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(243, 277);
            this.dataGridView1.TabIndex = 32;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(94, 208);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(88, 35);
            this.AddButton.TabIndex = 26;
            this.AddButton.Text = "Add to Cart";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // ProductCodeComboBox
            // 
            this.ProductCodeComboBox.FormattingEnabled = true;
            this.ProductCodeComboBox.Location = new System.Drawing.Point(48, 169);
            this.ProductCodeComboBox.Name = "ProductCodeComboBox";
            this.ProductCodeComboBox.Size = new System.Drawing.Size(100, 21);
            this.ProductCodeComboBox.TabIndex = 38;
            // 
            // QuantityUpDown
            // 
            this.QuantityUpDown.Location = new System.Drawing.Point(180, 170);
            this.QuantityUpDown.Name = "QuantityUpDown";
            this.QuantityUpDown.Size = new System.Drawing.Size(43, 20);
            this.QuantityUpDown.TabIndex = 39;
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
            // CartLabel
            // 
            this.CartLabel.AutoSize = true;
            this.CartLabel.Location = new System.Drawing.Point(272, 36);
            this.CartLabel.Name = "CartLabel";
            this.CartLabel.Size = new System.Drawing.Size(26, 13);
            this.CartLabel.TabIndex = 40;
            this.CartLabel.Text = "Cart";
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 466);
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
            this.Load += new System.EventHandler(this.CreateOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityUpDown)).EndInit();
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
    }
}