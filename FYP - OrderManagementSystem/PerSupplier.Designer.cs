namespace FYP___OrderManagementSystem
{
    partial class PerSupplier
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.fYP_DBDataSet1 = new FYP___OrderManagementSystem.FYP_DBDataSet1();
            this.suppOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppOrdersTableAdapter = new FYP___OrderManagementSystem.FYP_DBDataSet1TableAdapters.SuppOrdersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fYP_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppOrdersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.DataSource = this.suppOrdersBindingSource;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(24, 28);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.XValueMember = "Supplier";
            series2.YValueMembers = "Orders";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(664, 451);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // fYP_DBDataSet1
            // 
            this.fYP_DBDataSet1.DataSetName = "FYP_DBDataSet1";
            this.fYP_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suppOrdersBindingSource
            // 
            this.suppOrdersBindingSource.DataMember = "SuppOrders";
            this.suppOrdersBindingSource.DataSource = this.fYP_DBDataSet1;
            // 
            // suppOrdersTableAdapter
            // 
            this.suppOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // PerSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 515);
            this.Controls.Add(this.chart1);
            this.Location = new System.Drawing.Point(410, 15);
            this.Name = "PerSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PerSupplier";
            this.Load += new System.EventHandler(this.PerSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fYP_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppOrdersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private FYP_DBDataSet1 fYP_DBDataSet1;
        private System.Windows.Forms.BindingSource suppOrdersBindingSource;
        private FYP_DBDataSet1TableAdapters.SuppOrdersTableAdapter suppOrdersTableAdapter;
    }
}