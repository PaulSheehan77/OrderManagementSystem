using System;
using System.Windows.Forms;

namespace FYP___OrderManagementSystem
{
    public partial class DepOrdersBarChart : Form
    {
        public DepOrdersBarChart()
        {
            InitializeComponent();
        }

        private void DepOrdersBarChart_Load(object sender, EventArgs e)
        {
            this.orders_p_DepartmentTableAdapter.Fill(this.dS_DepOrders._Orders_p_Department);
        }
    }
}
