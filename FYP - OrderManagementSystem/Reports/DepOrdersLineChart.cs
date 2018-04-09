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
    public partial class DepOrdersLineChart : Form
    {
        public DepOrdersLineChart()
        {
            InitializeComponent();
        }

        private void DepOrdersLineChart_Load(object sender, EventArgs e)
        {
            this.orders_p_DepartmentTableAdapter.Fill(this.dS_DepOrders._Orders_p_Department);

        }
    }
}
