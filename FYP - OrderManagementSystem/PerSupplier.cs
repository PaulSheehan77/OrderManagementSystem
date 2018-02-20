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
    public partial class PerSupplier : Form
    {
        public PerSupplier()
        {
            InitializeComponent();
        }

        private void PerSupplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fYP_DBDataSet1.SuppOrders' table. You can move, or remove it, as needed.
            this.suppOrdersTableAdapter.Fill(this.fYP_DBDataSet1.SuppOrders);

        }
    }
}
