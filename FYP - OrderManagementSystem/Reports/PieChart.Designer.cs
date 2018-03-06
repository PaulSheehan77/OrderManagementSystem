namespace FYP___OrderManagementSystem
{
    partial class PieChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pieChart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pieChart1
            // 
            chartArea1.Name = "ChartArea1";
            this.pieChart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.pieChart1.Legends.Add(legend1);
            this.pieChart1.Location = new System.Drawing.Point(24, 21);
            this.pieChart1.Name = "pieChart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Department";
            this.pieChart1.Series.Add(series1);
            this.pieChart1.Size = new System.Drawing.Size(280, 247);
            this.pieChart1.TabIndex = 0;
            this.pieChart1.Text = "chart1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Orders Per Department";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(324, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "Orders Per Person";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PieChart
            // 
            this.ClientSize = new System.Drawing.Size(422, 293);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pieChart1);
            this.Name = "PieChart";
            ((System.ComponentModel.ISupportInitialize)(this.pieChart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ChartTypeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TableComboBox;
        private System.Windows.Forms.ComboBox YAxisComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox XAxisComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChart1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}