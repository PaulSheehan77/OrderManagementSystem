using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FYP___OrderManagementSystem
{
    public partial class Products : Form
    {
        private SqlConnection _connection;
        private SqlCommand _command;
        private SqlDataAdapter _sda;
        private DataTable _dt;

        public Products()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            _connection = DB_Connect.connect();
            _sda = new SqlDataAdapter(@"SELECT * FROM[Products] order by len(ProductCode), ProductCode", _connection);
            _dt = new DataTable();
            _sda.Fill(_dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow item in _dt.Rows)
            {
                var n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["ProductCode"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["ProductName"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["ProductSupplier"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["ProductSupplierCode"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["ProductPrice"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["ProductStock"].ToString();
            }
        }

        private bool IfProductExists(SqlConnection connection, string prodCode)
        {
            _sda = new SqlDataAdapter(@"SELECT 1 FROM[Products] WHERE[ProductCode] = '" + prodCode + "'", connection);
            _dt = new DataTable();
            _sda.Fill(_dt);
            if (_dt.Rows.Count > 0)
                return true;
            return false;
        }

        private void ClearText()
        {
            PCTextBox.Clear();
            PNTextBox.Clear();
            SNTextBox.Clear();
            SCTextBox.Clear();
            PriceTextBox.Clear();
            StockTextBox.Clear();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            const string errorMessage = "An item with this product code already exists.\n\nPlease enter a different product code.";
            _connection = DB_Connect.connect();
            _connection.Open();

            if (IfProductExists(_connection, PCTextBox.Text))
            {
                MessageBox.Show(errorMessage);
                PCTextBox.Clear();
                PCTextBox.Focus();
            }
            else
            {
                var sqlQuery = @"INSERT INTO[Products] ([ProductCode], [ProductName], [ProductSupplier], [ProductSupplierCode], [ProductPrice], [ProductStock]) VALUES
                      ('" + PCTextBox.Text + "', '" + PNTextBox.Text + "', '" + SNTextBox.Text + "', '" + SCTextBox.Text + "', '" + PriceTextBox.Text + "', '" + StockTextBox.Text + "')";
                _command = new SqlCommand(sqlQuery, _connection);
                _command.ExecuteNonQuery();
                ClearText();
                PCTextBox.Focus();
            }

            _connection.Close();
            LoadData();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            const string errorMessage = "An item with this product code doesn't exist.\n\nPlease enter a different product code.";
            _connection = DB_Connect.connect();
            _connection.Open();

            if (IfProductExists(_connection, PCTextBox.Text))
            {
                var sqlQuery = @"UPDATE[Products] SET[ProductName] = '" + PNTextBox.Text + "', [ProductSupplier] = '" + SNTextBox.Text + "' , [ProductSupplierCode] = '" + SCTextBox.Text + "', [ProductPrice] = '" + PriceTextBox.Text + "', [ProductStock] = '" + StockTextBox.Text + "' WHERE[ProductCode] = '" + PCTextBox.Text + "'";
                ClearText();
                PCTextBox.Focus();
                _command = new SqlCommand(sqlQuery, _connection);
                _command.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show(errorMessage);
                PCTextBox.Clear();
                PCTextBox.Focus();
            }
            
            _connection.Close();
            LoadData();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            const string errorMessage = "This item does not exist!";
            _connection = DB_Connect.connect();

            if (IfProductExists(_connection, PCTextBox.Text))
            {
                _connection.Open();
                var sqlQuery = @"DELETE FROM[Products] WHERE[ProductCode] = '" + PCTextBox.Text + "'";
                _command = new SqlCommand(sqlQuery, _connection);
                _command.ExecuteNonQuery();
                _connection.Close();
            }
            else
            {
                MessageBox.Show(errorMessage);
            }

            ClearText();
            PCTextBox.Focus();
            LoadData();
        }

        private void DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PCTextBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            PNTextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            SNTextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            SCTextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            PriceTextBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            StockTextBox.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
