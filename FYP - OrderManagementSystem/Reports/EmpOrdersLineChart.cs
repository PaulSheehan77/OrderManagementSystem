using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYP___OrderManagementSystem.Reports
{
    public partial class EmpOrdersLineChart : Form
    {
        public EmpOrdersLineChart()
        {
            InitializeComponent();
        }

        private void EmpOrdersLineChart_Load(object sender, EventArgs e)
        {
            this.orders_p_EmployeeTableAdapter.Fill(this.dB_EmpOrders._Orders_p_Employee);

        }
    }
}
