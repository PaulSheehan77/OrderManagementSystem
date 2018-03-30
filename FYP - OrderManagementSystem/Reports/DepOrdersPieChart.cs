using System;
using System.Windows.Forms;

namespace FYP___OrderManagementSystem
{
    public partial class DepOrdersPieChart : Form
    {
        public DepOrdersPieChart()
        {
            InitializeComponent();
        }

        private void DepOrdersPieChart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fYP_DBDataSet1.DepOrders' table. You can move, or remove it, as needed.
            this.depOrdersTableAdapter.Fill(this.fYP_DBDataSet1.DepOrders);

        }
    }
}
