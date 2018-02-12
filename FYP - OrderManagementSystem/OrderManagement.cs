using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FYP___OrderManagementSystem
{
    public partial class OrderManagement : Form
    {
        private SqlConnection _connection;
        private SqlCommand _command;
        private SqlDataAdapter _sda;
        private DataTable _dt;

        public OrderManagement()
        {
            InitializeComponent();
            Load_Data();
            OrderStatusComboBox.Items.Add("Declined");
            OrderStatusComboBox.Items.Add("Accepted");
            OrderStatusComboBox.Items.Add("In Progress");
            OrderStatusComboBox.Items.Add("Complete");
        }

        public void Load_Data()
        {
            OrderIDComboBox.Items.Clear();
            _connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            _sda = new SqlDataAdapter(@"SELECT * FROM[Orders]", _connection);
            _dt = new DataTable();
            _sda.Fill(_dt);
            dataGridView2.Rows.Clear();
            //TimeLabel.Location = new Point(914, 498);
            FillComboBox(_connection);

            foreach (DataRow item in _dt.Rows)
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = item["OrderID"].ToString();
                dataGridView2.Rows[n].Cells[1].Value = item["NumberOFItems"].ToString();
                dataGridView2.Rows[n].Cells[2].Value = item["Department"].ToString();
                dataGridView2.Rows[n].Cells[3].Value = item["Requestee"].ToString();
                dataGridView2.Rows[n].Cells[4].Value = item["OrderDate"].ToString();
                dataGridView2.Rows[n].Cells[5].Value = item["OrderStatus"].ToString();
                dataGridView2.Rows[n].Cells[6].Value = item["OrderTotal"].ToString();
                /*if ((bool)item["ProductStatus"])
                {
                    dataGridView1.Rows[n].Cells[2].Value = "Active";
                }
                else
                {
                    dataGridView1.Rows[n].Cells[2].Value = "Deactive";
                }*/
            }
        }

        private void FillComboBox(SqlConnection connection)
        {
            _command = new SqlCommand(@"SELECT * FROM[Orders]", connection);
            try
            {
                _connection.Open();
                var myReader = _command.ExecuteReader();

                while (myReader.Read())
                {
                    var pCode = myReader.GetString(0);
                    OrderIDComboBox.Items.Add(pCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private bool IfOrderExists(SqlConnection connection, string orderId)
        {
            _sda = new SqlDataAdapter(@"SELECT 1 FROM[Orders] WHERE[OrderID] = '" + orderId + "'", connection);
            _dt = new DataTable();
            _sda.Fill(_dt);
            if (_dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            const string errorMessage = "An order with this order ID doesn't exist.\n\nPlease enter a different order id.";
            _connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            _connection.Open();

            if (IfOrderExists(_connection, OrderIDComboBox.Text))
            {
                var sqlQuery = @"UPDATE[Orders] SET[OrderStatus] = '" + OrderStatusComboBox.Text + "' WHERE [OrderID] = '" + OrderIDComboBox.Text + "'";
                OrderStatusComboBox.SelectedIndex = -1;
                OrderIDComboBox.SelectedIndex = -1;
                OrderIDComboBox.Focus();
                _command = new SqlCommand(sqlQuery, _connection);
                _command.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show(errorMessage);
                OrderIDComboBox.SelectedIndex = -1;
                OrderIDComboBox.Focus();
            }

            _connection.Close();
            Load_Data();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void DataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OrderIDComboBox.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            OrderStatusComboBox.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}
