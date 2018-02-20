namespace FYP___OrderManagementSystem
{
    partial class PerDepartment
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
            this.depOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fYP_DBDataSet = new FYP___OrderManagementSystem.FYP_DBDataSet();
            this.depOrdersTableAdapter = new FYP___OrderManagementSystem.FYP_DBDataSetTableAdapters.DepOrdersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fYP_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.DataSource = this.depOrdersBindingSource;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(61, 38);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.XValueMember = "Department";
            series2.YValueMembers = "NumberOfOrders";
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(565, 362);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // depOrdersBindingSource
            // 
            this.depOrdersBindingSource.DataMember = "DepOrders";
            this.depOrdersBindingSource.DataSource = this.fYP_DBDataSet;
            // 
            // fYP_DBDataSet
            // 
            this.fYP_DBDataSet.DataSetName = "FYP_DBDataSet";
            this.fYP_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // depOrdersTableAdapter
            // 
            this.depOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // PerDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 460);
            this.Controls.Add(this.chart1);
            this.Location = new System.Drawing.Point(410, 15);
            this.Name = "PerDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fYP_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private FYP_DBDataSet fYP_DBDataSet;
        private System.Windows.Forms.BindingSource depOrdersBindingSource;
        private FYP_DBDataSetTableAdapters.DepOrdersTableAdapter depOrdersTableAdapter;
    }
}