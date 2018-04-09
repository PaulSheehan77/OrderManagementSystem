namespace FYP___OrderManagementSystem.Reports
{
    partial class DepOrdersLineChart
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
            this.dS_DepOrders = new FYP___OrderManagementSystem.DS_DepOrders();
            this.ordersPDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orders_p_DepartmentTableAdapter = new FYP___OrderManagementSystem.DS_DepOrdersTableAdapters.Orders_p_DepartmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DepOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersPDepartmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.ordersPDepartmentBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Orders";
            series1.XValueMember = "Department";
            series1.YValueMembers = "Orders";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(524, 318);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // dS_DepOrders
            // 
            this.dS_DepOrders.DataSetName = "DS_DepOrders";
            this.dS_DepOrders.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersPDepartmentBindingSource
            // 
            this.ordersPDepartmentBindingSource.DataMember = "Orders p/Department";
            this.ordersPDepartmentBindingSource.DataSource = this.dS_DepOrders;
            // 
            // orders_p_DepartmentTableAdapter
            // 
            this.orders_p_DepartmentTableAdapter.ClearBeforeFill = true;
            // 
            // DepOrdersLineChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 318);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DepOrdersLineChart";
            this.Text = "DepOrdersLineChart";
            this.Load += new System.EventHandler(this.DepOrdersLineChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DepOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersPDepartmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DS_DepOrders dS_DepOrders;
        private System.Windows.Forms.BindingSource ordersPDepartmentBindingSource;
        private DS_DepOrdersTableAdapters.Orders_p_DepartmentTableAdapter orders_p_DepartmentTableAdapter;
    }
}