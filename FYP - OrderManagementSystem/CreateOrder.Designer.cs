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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateOrder));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.DepComboBox = new System.Windows.Forms.ComboBox();
            this.RequestedByLabel = new System.Windows.Forms.Label();
            this.DepLabel = new System.Windows.Forms.Label();
            this.RequesteeTextBox = new System.Windows.Forms.TextBox();
            this.CartLabel = new System.Windows.Forms.Label();
            this.SOButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.QuantityUpDown = new System.Windows.Forms.NumericUpDown();
            this.ProductCodeComboBox = new System.Windows.Forms.ComboBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.PCLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityUpDown)).BeginInit();
            this.SuspendLayout();
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
            this.Column6});
            this.dataGridView2.Location = new System.Drawing.Point(12, 84);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(575, 149);
            this.dataGridView2.TabIndex = 6;
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
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.DepComboBox);
            this.panel1.Controls.Add(this.RequestedByLabel);
            this.panel1.Controls.Add(this.DepLabel);
            this.panel1.Controls.Add(this.RequesteeTextBox);
            this.panel1.Controls.Add(this.CartLabel);
            this.panel1.Controls.Add(this.SOButton);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(11, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 182);
            this.panel1.TabIndex = 42;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(398, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 25);
            this.button1.TabIndex = 57;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DepComboBox
            // 
            this.DepComboBox.FormattingEnabled = true;
            this.DepComboBox.Location = new System.Drawing.Point(459, 26);
            this.DepComboBox.Name = "DepComboBox";
            this.DepComboBox.Size = new System.Drawing.Size(100, 21);
            this.DepComboBox.TabIndex = 3;
            // 
            // RequestedByLabel
            // 
            this.RequestedByLabel.AutoSize = true;
            this.RequestedByLabel.BackColor = System.Drawing.Color.Transparent;
            this.RequestedByLabel.Location = new System.Drawing.Point(456, 55);
            this.RequestedByLabel.Name = "RequestedByLabel";
            this.RequestedByLabel.Size = new System.Drawing.Size(73, 13);
            this.RequestedByLabel.TabIndex = 56;
            this.RequestedByLabel.Text = "Requested by";
            // 
            // DepLabel
            // 
            this.DepLabel.AutoSize = true;
            this.DepLabel.BackColor = System.Drawing.Color.Transparent;
            this.DepLabel.Location = new System.Drawing.Point(456, 11);
            this.DepLabel.Name = "DepLabel";
            this.DepLabel.Size = new System.Drawing.Size(62, 13);
            this.DepLabel.TabIndex = 55;
            this.DepLabel.Text = "Department";
            // 
            // RequesteeTextBox
            // 
            this.RequesteeTextBox.Location = new System.Drawing.Point(459, 71);
            this.RequesteeTextBox.Name = "RequesteeTextBox";
            this.RequesteeTextBox.Size = new System.Drawing.Size(100, 20);
            this.RequesteeTextBox.TabIndex = 4;
            // 
            // CartLabel
            // 
            this.CartLabel.AutoSize = true;
            this.CartLabel.Location = new System.Drawing.Point(9, 11);
            this.CartLabel.Name = "CartLabel";
            this.CartLabel.Size = new System.Drawing.Size(26, 13);
            this.CartLabel.TabIndex = 53;
            this.CartLabel.Text = "Cart";
            // 
            // SOButton
            // 
            this.SOButton.Location = new System.Drawing.Point(471, 151);
            this.SOButton.Name = "SOButton";
            this.SOButton.Size = new System.Drawing.Size(78, 26);
            this.SOButton.TabIndex = 5;
            this.SOButton.Text = "Submit Order";
            this.SOButton.UseVisualStyleBackColor = true;
            this.SOButton.Click += new System.EventHandler(this.SOButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(51, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(380, 166);
            this.dataGridView1.TabIndex = 7;
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
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.QuantityUpDown);
            this.panel2.Controls.Add(this.ProductCodeComboBox);
            this.panel2.Controls.Add(this.QuantityLabel);
            this.panel2.Controls.Add(this.PCLabel);
            this.panel2.Controls.Add(this.AddButton);
            this.panel2.Location = new System.Drawing.Point(11, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 66);
            this.panel2.TabIndex = 43;
            // 
            // QuantityUpDown
            // 
            this.QuantityUpDown.Location = new System.Drawing.Point(270, 35);
            this.QuantityUpDown.Name = "QuantityUpDown";
            this.QuantityUpDown.Size = new System.Drawing.Size(43, 20);
            this.QuantityUpDown.TabIndex = 1;
            // 
            // ProductCodeComboBox
            // 
            this.ProductCodeComboBox.FormattingEnabled = true;
            this.ProductCodeComboBox.Location = new System.Drawing.Point(12, 34);
            this.ProductCodeComboBox.Name = "ProductCodeComboBox";
            this.ProductCodeComboBox.Size = new System.Drawing.Size(100, 21);
            this.ProductCodeComboBox.TabIndex = 0;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.BackColor = System.Drawing.Color.Transparent;
            this.QuantityLabel.Location = new System.Drawing.Point(267, 19);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(46, 13);
            this.QuantityLabel.TabIndex = 42;
            this.QuantityLabel.Text = "Quantity";
            // 
            // PCLabel
            // 
            this.PCLabel.AutoSize = true;
            this.PCLabel.BackColor = System.Drawing.Color.Transparent;
            this.PCLabel.Location = new System.Drawing.Point(10, 19);
            this.PCLabel.Name = "PCLabel";
            this.PCLabel.Size = new System.Drawing.Size(72, 13);
            this.PCLabel.TabIndex = 41;
            this.PCLabel.Text = "Product Code";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(489, 29);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(70, 26);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add to Cart";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 48);
            this.button2.TabIndex = 58;
            this.button2.Text = "Clear Cart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 433);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(410, 51);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1326, 653);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(617, 453);
            this.Name = "CreateOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Create Order";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateOrder_FormClosing);
            this.Load += new System.EventHandler(this.CreateOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox DepComboBox;
        private System.Windows.Forms.Label RequestedByLabel;
        private System.Windows.Forms.Label DepLabel;
        private System.Windows.Forms.TextBox RequesteeTextBox;
        private System.Windows.Forms.Label CartLabel;
        private System.Windows.Forms.Button SOButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown QuantityUpDown;
        private System.Windows.Forms.ComboBox ProductCodeComboBox;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label PCLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}