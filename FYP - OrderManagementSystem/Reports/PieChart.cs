using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FYP___OrderManagementSystem
{
    public partial class PieChart : Form
    {
        public PieChart()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FYP_DBEntities db = new FYP_DBEntities())
            {
                //pieChart1.DataSource = db.DepOrders
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}