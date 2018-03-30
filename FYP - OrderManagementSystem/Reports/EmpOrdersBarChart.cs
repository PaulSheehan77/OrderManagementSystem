using System;
using System.Windows.Forms;

namespace FYP___OrderManagementSystem.Reports
{
    public partial class EmpOrdersBarChart : Form
    {
        public EmpOrdersBarChart()
        {
            InitializeComponent();
        }

        private void EmpOrdersBarChart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fYP_DBDataSet2.EmpOrders' table. You can move, or remove it, as needed.
            this.empOrdersTableAdapter.Fill(this.fYP_DBDataSet2.EmpOrders);

        }
    }
}
