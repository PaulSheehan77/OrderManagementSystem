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
            this.orders_p_EmployeeTableAdapter.Fill(this.dB_EmpOrders._Orders_p_Employee);
        }
    }
}
