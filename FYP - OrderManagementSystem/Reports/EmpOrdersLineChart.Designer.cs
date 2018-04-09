namespace FYP___OrderManagementSystem.Reports
{
    partial class EmpOrdersLineChart
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
            this.dB_EmpOrders = new FYP___OrderManagementSystem.DB_EmpOrders();
            this.ordersPEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orders_p_EmployeeTableAdapter = new FYP___OrderManagementSystem.DB_EmpOrdersTableAdapters.Orders_p_EmployeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EmpOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersPEmployeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.ordersPEmployeeBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 1);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Orders";
            series1.XValueMember = "Employee";
            series1.YValueMembers = "Orders";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(524, 318);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // dB_EmpOrders
            // 
            this.dB_EmpOrders.DataSetName = "DB_EmpOrders";
            this.dB_EmpOrders.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersPEmployeeBindingSource
            // 
            this.ordersPEmployeeBindingSource.DataMember = "Orders p/Employee";
            this.ordersPEmployeeBindingSource.DataSource = this.dB_EmpOrders;
            // 
            // orders_p_EmployeeTableAdapter
            // 
            this.orders_p_EmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // EmpOrdersLineChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 318);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmpOrdersLineChart";
            this.Text = "EmpOrdersLineChart";
            this.Load += new System.EventHandler(this.EmpOrdersLineChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EmpOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersPEmployeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DB_EmpOrders dB_EmpOrders;
        private System.Windows.Forms.BindingSource ordersPEmployeeBindingSource;
        private DB_EmpOrdersTableAdapters.Orders_p_EmployeeTableAdapter orders_p_EmployeeTableAdapter;
    }
}