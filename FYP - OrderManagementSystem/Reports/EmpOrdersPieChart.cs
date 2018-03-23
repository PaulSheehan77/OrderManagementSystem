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
    public partial class EmpOrdersPieChart : Form
    {
        public EmpOrdersPieChart()
        {
            InitializeComponent();
        }

        private void EmpOrdersPieChart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fYP_DBDataSet3.EmpOrders' table. You can move, or remove it, as needed.
            this.empOrdersTableAdapter.Fill(this.fYP_DBDataSet3.EmpOrders);

        }
    }
}
