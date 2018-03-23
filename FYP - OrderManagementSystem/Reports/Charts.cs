using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FYP___OrderManagementSystem
{
    public partial class Charts : Form
    {
        Chart chart1;
        private SqlConnection _connection;
        private SqlCommand _command;
        private SqlDataAdapter _sda;
        private DataTable _dt;
        private string x = "Line";

        public Charts()
        {
            InitializeComponent();
            LoadData();
        }
        private double f(int i)
        {
            var f1 = 59894 - (8128 * i) + (262 * i * i) - (1.6 * i * i * i);
            return f1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart2.Series.Clear();
            var series1 = new Series
            {
                Name = "OrdersPerDep",
                Color = System.Drawing.Color.Green,
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Line
            };

            this.chart2.Series.Add(series1);

            for (int i = 0; i < 100; i++)
            {
                series1.Points.AddXY(i, f(i));
            }
            chart1.Invalidate();
        }

        private void LoadData()
        {
            ChartTypeComboBox.Items.Clear();
            TableComboBox.Items.Clear();
            FillComboBox();
            FillComboBox2();
            components = new System.ComponentModel.Container();
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            this.chart1 = new Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            //
            // chart1
            //
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 50);
            this.chart1.Name = "Orders Per Department";
            // this.chart1.Size = new System.Drawing.Size(284, 212);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "FakeChart";
            this.Load += new EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
        }

        private void FillComboBox()
        {
            _connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            _command = new SqlCommand(@"SELECT * FROM[Products]", _connection);
            try
            {
                _connection.Open();
                ChartTypeComboBox.Items.Add("Line");
                ChartTypeComboBox.Items.Add("Pie");
                _connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillComboBox2()
        {
            _connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            _connection.Open();
            _dt = _connection.GetSchema("Tables");

            foreach (DataRow item in _dt.Rows)
            {
                string tablename = (string)item[2];
                TableComboBox.Items.Add(tablename);
            }
            _connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart2.Series.Clear();
            Series series1 = new Series{};
            if (ChartTypeComboBox.Text == "Line")
            {
                series1 = new Series
            {
                Name = "OrdersPerDep",
                Color = System.Drawing.Color.Green,
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Line
            };
                
            }
            else if (ChartTypeComboBox.Text == "Pie")
            {
                series1 = new Series
                {
                    Name = "OrdersPerDep",
                    Color = System.Drawing.Color.Green,
                    IsVisibleInLegend = true,
                    IsXValueIndexed = true,
                    ChartType = SeriesChartType.Pie
                };

            }

            _connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");

            if (TableComboBox.Text == "SuppOrders")
            {
                _sda = new SqlDataAdapter(@"SELECT * FROM[SuppOrders]", _connection); // order by len(ProductCode), ProductCode
                _dt = new DataTable();
                _sda.Fill(_dt);

                foreach (DataRow item in _dt.Rows)
                {
                    series1.Points.AddXY(item["Supplier"].ToString(), item["Orders"].ToString());
                }

                this.chart2.Series.Add(series1);
            }

            else if (TableComboBox.Text == "DepOrders")
            {
                _sda = new SqlDataAdapter(@"SELECT * FROM[DepOrders]", _connection);
                _dt = new DataTable();
                _sda.Fill(_dt);

                foreach (DataRow item in _dt.Rows)
                {
                    series1.Points.AddXY(item["Department"].ToString(), item["Orders"].ToString());
                }

                this.chart2.Series.Add(series1);
            }

            chart2.Invalidate();
            //LoadData();
        }
    }
}

/*
 
    using System;
    using System.Windows.Forms;
    using System.Windows.Forms.DataVisualization.Charting;


namespace Dino.Tools.WebMonitor
{
    public class FakeChartForm1 : Form
    {
        private System.ComponentModel.IContainer components = null;
        System.Windows.Forms.DataVisualization.Charting.Chart chart1;

        public FakeChartForm1 ()
        {
            InitializeComponent();
        }

        private double f(int i)
        {
            var f1 = 59894 - (8128 * i) + (262 * i * i) - (1.6 * i * i * i);
            return f1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Series1",
                Color = System.Drawing.Color.Green,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Line
            };

            this.chart1.Series.Add(series1);

            for (int i=0; i < 100; i++)
            {
                series1.Points.AddXY(i, f(i));
            }
            chart1.Invalidate();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            //
            // chart1
            //
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 50);
            this.chart1.Name = "chart1";
            // this.chart1.Size = new System.Drawing.Size(284, 212);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "FakeChart";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FakeChartForm1());
        }
    }
}
 * 
 */
