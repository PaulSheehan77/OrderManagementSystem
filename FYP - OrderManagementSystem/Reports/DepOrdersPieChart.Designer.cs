namespace FYP___OrderManagementSystem
{
    partial class DepOrdersPieChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.fYP_DBDataSet = new FYP___OrderManagementSystem.FYP_DBDataSet();
            this.fYPDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fYP_DBDataSet1 = new FYP___OrderManagementSystem.FYP_DBDataSet1();
            this.depOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depOrdersTableAdapter = new FYP___OrderManagementSystem.FYP_DBDataSet1TableAdapters.DepOrdersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fYP_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fYPDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fYP_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depOrdersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.depOrdersBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(23, 22);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "Department";
            series1.YValueMembers = "NumberOfOrders";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(411, 363);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // fYP_DBDataSet
            // 
            this.fYP_DBDataSet.DataSetName = "FYP_DBDataSet";
            this.fYP_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fYPDBDataSetBindingSource
            // 
            this.fYPDBDataSetBindingSource.DataSource = this.fYP_DBDataSet;
            this.fYPDBDataSetBindingSource.Position = 0;
            // 
            // fYP_DBDataSet1
            // 
            this.fYP_DBDataSet1.DataSetName = "FYP_DBDataSet1";
            this.fYP_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // depOrdersBindingSource
            // 
            this.depOrdersBindingSource.DataMember = "DepOrders";
            this.depOrdersBindingSource.DataSource = this.fYP_DBDataSet1;
            // 
            // depOrdersTableAdapter
            // 
            this.depOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // DepOrdersPieChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 411);
            this.Controls.Add(this.chart1);
            this.Name = "DepOrdersPieChart";
            this.Text = "DepOrdersPieChart";
            this.Load += new System.EventHandler(this.DepOrdersPieChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fYP_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fYPDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fYP_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depOrdersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource fYPDBDataSetBindingSource;
        private FYP_DBDataSet fYP_DBDataSet;
        private FYP_DBDataSet1 fYP_DBDataSet1;
        private System.Windows.Forms.BindingSource depOrdersBindingSource;
        private FYP_DBDataSet1TableAdapters.DepOrdersTableAdapter depOrdersTableAdapter;
    }
}