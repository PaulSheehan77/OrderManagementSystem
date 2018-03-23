using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            // TODO: This line of code loads data into the 'fYP_DBDataSet.DepOrders' table. You can move, or remove it, as needed.
            this.depOrdersTableAdapter.Fill(this.fYP_DBDataSet.DepOrders);

        }
    }
}
