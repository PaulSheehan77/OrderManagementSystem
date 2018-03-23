namespace FYP___OrderManagementSystem.Reports
{
    partial class EmpOrdersPieChart
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
            this.fYP_DBDataSet3 = new FYP___OrderManagementSystem.FYP_DBDataSet3();
            this.empOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empOrdersTableAdapter = new FYP___OrderManagementSystem.FYP_DBDataSet3TableAdapters.EmpOrdersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fYP_DBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empOrdersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.empOrdersBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(28, 23);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "Employee Name";
            series1.YValueMembers = "Orders";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(411, 363);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // fYP_DBDataSet3
            // 
            this.fYP_DBDataSet3.DataSetName = "FYP_DBDataSet3";
            this.fYP_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empOrdersBindingSource
            // 
            this.empOrdersBindingSource.DataMember = "EmpOrders";
            this.empOrdersBindingSource.DataSource = this.fYP_DBDataSet3;
            // 
            // empOrdersTableAdapter
            // 
            this.empOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // EmpOrdersPieChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 411);
            this.Controls.Add(this.chart1);
            this.Name = "EmpOrdersPieChart";
            this.Text = "EmpOrdersPieChart";
            this.Load += new System.EventHandler(this.EmpOrdersPieChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fYP_DBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empOrdersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private FYP_DBDataSet3 fYP_DBDataSet3;
        private System.Windows.Forms.BindingSource empOrdersBindingSource;
        private FYP_DBDataSet3TableAdapters.EmpOrdersTableAdapter empOrdersTableAdapter;
    }
}