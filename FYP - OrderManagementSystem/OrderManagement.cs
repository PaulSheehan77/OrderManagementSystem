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
            _connection = DB_Connect.connect();
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
                dataGridView2.Rows[n].Cells[2].Value = item[Constants.dep].ToString();
                dataGridView2.Rows[n].Cells[3].Value = item[Constants.req].ToString();
                dataGridView2.Rows[n].Cells[4].Value = item["OrderDate"].ToString();
                dataGridView2.Rows[n].Cells[5].Value = item["OrderStatus"].ToString();
                dataGridView2.Rows[n].Cells[6].Value = item["OrderTotal"].ToString();
            }
        }

        private bool CheckIfDepExists(SqlConnection connection, string dep)
        {
            _sda = new SqlDataAdapter(@"SELECT 1 FROM[Orders p/Department] WHERE[Department] = '" + dep + "'", connection);
            _dt = new DataTable();
            _sda.Fill(_dt);
            if (_dt.Rows.Count > 0)
                return true;
            return false;
        }

        private bool CheckIfEmpExists(SqlConnection connection, string emp)
        {
            _sda = new SqlDataAdapter(@"SELECT 1 FROM[Orders p/Employee] WHERE[Employee] = '" + emp + "'", connection);
            _dt = new DataTable();
            _sda.Fill(_dt);
            if (_dt.Rows.Count > 0)
                return true;
            return false;
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
            var localDate = DateTime.Today;
            var dep = "";
            var emp = "";
            const string errorMessage = "An order with this order ID doesn't exist.\n\nPlease enter a different order id.";
            _connection = DB_Connect.connect();

            if (IfOrderExists(_connection, OrderIDComboBox.Text))
            {
                string sqlQuery;
                if (OrderStatusComboBox.Text == "Complete")
                {
                    _command = new SqlCommand(@"SELECT * FROM[Orders] WHERE [OrderId] = '" + OrderIDComboBox.Text + "'", _connection);
                    _connection.Open();
                    try
                    {
                        var myReader = _command.ExecuteReader();

                        while (myReader.Read())
                        {
                            dep = myReader.GetString(2);
                            emp = myReader.GetString(3);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    _connection.Close();

                    if (!CheckIfDepExists(_connection, dep))
                    {
                        sqlQuery = @"INSERT INTO[Orders p/Department] ([Department],[Orders]) VALUES ('" + dep + "','" + 0 + "')";
                        _connection.Open();
                        _command = new SqlCommand(sqlQuery, _connection);
                        _command.ExecuteNonQuery();
                        _connection.Close();
                    }
                    sqlQuery = @"UPDATE[Orders p/Department] SET[Orders] = [Orders] + 1 WHERE [Department] = (SELECT[Department] FROM[Orders] WHERE[OrderID] = '" + OrderIDComboBox.Text + "')";
                    _connection.Open();
                    _command = new SqlCommand(sqlQuery, _connection);
                    _command.ExecuteNonQuery();
                    _connection.Close();

                    if (!CheckIfEmpExists(_connection, emp))
                    {
                        sqlQuery = @"INSERT INTO[Orders p/Employee] ([Employee],[Orders]) VALUES ('" + emp + "','" + 0 + "')";
                        _connection.Open();
                        _command = new SqlCommand(sqlQuery, _connection);
                        _command.ExecuteNonQuery();
                        _connection.Close();
                    }
                    sqlQuery = @"UPDATE[Orders p/Employee] SET[Orders] = [Orders] + 1 WHERE [Employee] = (SELECT[Requestee] FROM[Orders] WHERE[OrderID] = '" + OrderIDComboBox.Text + "')";
                    _connection.Open();
                    _command = new SqlCommand(sqlQuery, _connection);
                    _command.ExecuteNonQuery();
                    _connection.Close();
                }

                sqlQuery = @"UPDATE[Orders] SET[OrderStatus] = '" + OrderStatusComboBox.Text + "' WHERE [OrderID] = '" + OrderIDComboBox.Text + "'";
                _connection.Open();
                OrderStatusComboBox.SelectedIndex = -1;
                OrderIDComboBox.SelectedIndex = -1;
                OrderIDComboBox.Focus();
                _command = new SqlCommand(sqlQuery, _connection);
                _command.ExecuteNonQuery();
                _connection.Close();
                sqlQuery = @"UPDATE[Orders] SET[OrderDate] = '" + localDate.ToString().Substring(0, 10) + "' WHERE [OrderID] = '" + OrderIDComboBox.Text + "'";
                _connection.Open();
                _command = new SqlCommand(sqlQuery, _connection);
                _command.ExecuteNonQuery();
                _connection.Close();
            }
            else
            {
                MessageBox.Show(errorMessage);
                OrderIDComboBox.SelectedIndex = -1;
                OrderIDComboBox.Focus();
            }
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

        private void Button1_Click(object sender, EventArgs e)
        {
            _connection = DB_Connect.connect();
            _connection.Open();
            var sqlQuery = @"DELETE FROM[Orders] WHERE[OrderID] = '" + dataGridView2.Rows[0].Cells[0].Value + "'";
            _command = new SqlCommand(sqlQuery, _connection);
            _command.ExecuteNonQuery();
            _connection.Close();
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                dataGridView2.Rows.RemoveAt(row.Index);
            }
        }
    }
}
