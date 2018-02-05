using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FYP___OrderManagementSystem
{
    public partial class OrderManagement : Form
    {
        public OrderManagement()
        {
            InitializeComponent();
            Load_Data();
            OrderStatusComboBox.Items.Add("Deactive");
            OrderStatusComboBox.Items.Add("Active");
            OrderStatusComboBox.Items.Add("Complete");
        }

        public void Load_Data()
        {
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM[Orders]", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.Rows.Clear();
            //TimeLabel.Location = new Point(914, 498);
            FillComboBox(connection);

            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = item["OrderID"].ToString();
                dataGridView2.Rows[n].Cells[1].Value = item["NumberOFItems"].ToString();
                dataGridView2.Rows[n].Cells[2].Value = item["Department"].ToString();
                dataGridView2.Rows[n].Cells[3].Value = item["Requestee"].ToString();
                dataGridView2.Rows[n].Cells[4].Value = item["OrderDate"].ToString();
                dataGridView2.Rows[n].Cells[5].Value = item["OrderStatus"].ToString();
                dataGridView2.Rows[n].Cells[6].Value = item["OrderTotal"].ToString();
            }
        }

        private void FillComboBox(SqlConnection connection)
        {
            var command = new SqlCommand(@"SELECT * FROM[Orders]", connection);
            try
            {
                connection.Open();
                var myReader = command.ExecuteReader();

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


        private static bool IfOrderExists(SqlConnection connection, string orderId)
        {
            var sda = new SqlDataAdapter(@"SELECT 1 FROM[Orders] WHERE[OrderID] = '" + orderId + "'", connection);
            var dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            const string errorMessage = "An order with this order ID doesn't exist.\n\nPlease enter a different order id.";
            var connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            connection.Open();

            if (IfOrderExists(connection, OrderIDComboBox.Text))
            {
                var sqlQuery = @"UPDATE[Orders] SET[OrderStatus] = '" + OrderStatusComboBox.Text + "' WHERE [OrderID] = '" + OrderIDComboBox.Text + "'";
                OrderStatusComboBox.SelectedIndex = -1;
                OrderIDComboBox.SelectedIndex = -1;
                OrderIDComboBox.Focus();
                var command = new SqlCommand(sqlQuery, connection);
                command.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show(errorMessage);
                OrderIDComboBox.SelectedIndex = -1;
                OrderIDComboBox.Focus();
            }

            connection.Close();
            Load_Data();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void DataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OrderIDComboBox.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            OrderStatusComboBox.Text = dataGridView2.SelectedRows[0].Cells[6].Value.ToString();
        }
    }
}
