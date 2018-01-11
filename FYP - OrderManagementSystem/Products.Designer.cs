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
            this.PCLabel = new System.Windows.Forms.Label();
            this.PNLabel = new System.Windows.Forms.Label();
            this.SCLabel = new System.Windows.Forms.Label();
            this.SNLabel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SCTextBox = new System.Windows.Forms.TextBox();
            this.SNTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
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
            this.DeleteButton.Location = new System.Drawing.Point(636, 53);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(88, 34);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(636, 16);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(88, 33);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(36, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(688, 277);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
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
            // 
            // PCLabel
            // 
            this.PCLabel.AutoSize = true;
            this.PCLabel.Location = new System.Drawing.Point(33, 28);
            this.PCLabel.Name = "PCLabel";
            this.PCLabel.Size = new System.Drawing.Size(72, 13);
            this.PCLabel.TabIndex = 6;
            this.PCLabel.Text = "Product Code";
            // 
            // PNLabel
            // 
            this.PNLabel.AutoSize = true;
            this.PNLabel.Location = new System.Drawing.Point(208, 28);
            this.PNLabel.Name = "PNLabel";
            this.PNLabel.Size = new System.Drawing.Size(75, 13);
            this.PNLabel.TabIndex = 7;
            this.PNLabel.Text = "Product Name";
            // 
            // SCLabel
            // 
            this.SCLabel.AutoSize = true;
            this.SCLabel.Location = new System.Drawing.Point(208, 76);
            this.SCLabel.Name = "SCLabel";
            this.SCLabel.Size = new System.Drawing.Size(73, 13);
            this.SCLabel.TabIndex = 15;
            this.SCLabel.Text = "Supplier Code";
            // 
            // SNLabel
            // 
            this.SNLabel.AutoSize = true;
            this.SNLabel.Location = new System.Drawing.Point(33, 76);
            this.SNLabel.Name = "SNLabel";
            this.SNLabel.Size = new System.Drawing.Size(76, 13);
            this.SNLabel.TabIndex = 14;
            this.SNLabel.Text = "Supplier Name";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(636, 93);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(88, 33);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // SCTextBox
            // 
            this.SCTextBox.Location = new System.Drawing.Point(211, 93);
            this.SCTextBox.Name = "SCTextBox";
            this.SCTextBox.Size = new System.Drawing.Size(100, 20);
            this.SCTextBox.TabIndex = 3;
            // 
            // SNTextBox
            // 
            this.SNTextBox.Location = new System.Drawing.Point(36, 92);
            this.SNTextBox.Name = "SNTextBox";
            this.SNTextBox.Size = new System.Drawing.Size(100, 20);
            this.SNTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Price";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(381, 95);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriceTextBox.TabIndex = 4;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 454);
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
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Products";
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
    }
}