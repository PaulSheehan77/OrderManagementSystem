using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FYP___OrderManagementSystem
{
    public partial class Suppliers : Form
    {
        private SqlConnection _connection;
        private SqlCommand _command;
        private SqlDataAdapter _sda;
        private DataTable _dt;

        public Suppliers()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            _connection = DB_Connect.connect();
            _sda = new SqlDataAdapter(@"SELECT * FROM[Suppliers] order by SupplierName", _connection);
            _dt = new DataTable();
            _sda.Fill(_dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow item in _dt.Rows)
            {
                var n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["SupplierName"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["SupplierAddress"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["SupplierNumber"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["SupplierEmail"].ToString();
            }
        }

        private bool IfSupplierExists(SqlConnection connection, string supplierName)
        {
            _sda = new SqlDataAdapter(@"SELECT 1 FROM[Suppliers] WHERE[SupplierName] = '" + supplierName + "'", connection);
            _dt = new DataTable();
            _sda.Fill(_dt);
            if (_dt.Rows.Count > 0)
                return true;
            return false;
        }

        private void ClearText()
        {
            SETextBox.Clear();
            SATextBox.Clear();
            SNTextBox.Clear();
            SNUTextBox.Clear();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            const string errorMessage = "A supplier with this name already exists.\n\nPlease enter a different name.";
            _connection = DB_Connect.connect();
            _connection.Open();

            if (IfSupplierExists(_connection, SNTextBox.Text))
            {
                MessageBox.Show(errorMessage);
                SNTextBox.Clear();
                SNTextBox.Focus();
            }
            else
            {
                var sqlQuery = @"INSERT INTO[Suppliers] ([SupplierName], [SupplierAddress], [SupplierNumber], [SupplierEmail]) VALUES
                      ('" + SNTextBox.Text + "', '" + SATextBox.Text + "', '" + SNUTextBox.Text + "', '" + SETextBox.Text + "')";
                _command = new SqlCommand(sqlQuery, _connection);
                _command.ExecuteNonQuery();
                ClearText();
                SNTextBox.Focus();
            }

            _connection.Close();
            LoadData();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            const string errorMessage = "A supplier with this name doesn't exist.\n\nPlease enter a different name.";
            _connection = DB_Connect.connect();
            _connection.Open();

            if (IfSupplierExists(_connection, SNTextBox.Text))
            {
                var sqlQuery = @"UPDATE[Suppliers] SET[SupplierName] = '" + SNTextBox.Text + "', [SupplierAddress] = '" + SATextBox.Text + "' , [SupplierNumber] = '" + SNUTextBox.Text + "', [SupplierEmail] = '" + SETextBox.Text + "' WHERE[SupplierName] = '" + SNTextBox.Text + "'";
                ClearText();
                SNTextBox.Focus();
                 _command = new SqlCommand(sqlQuery, _connection);
                _command.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show(errorMessage);
                SNTextBox.Clear();
                SNTextBox.Focus();
            }

            _connection.Close();
            LoadData();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            const string errorMessage = "This supplier does not exist!";
            _connection = DB_Connect.connect();

            if (IfSupplierExists(_connection, SNTextBox.Text))
            {
                _connection.Open();
                var sqlQuery = @"DELETE FROM[Suppliers] WHERE[SupplierName] = '" + SNTextBox.Text + "'";
                _command = new SqlCommand(sqlQuery, _connection);
                _command.ExecuteNonQuery();
                _connection.Close();
            }
            else
            {
                MessageBox.Show(errorMessage);
            }

            ClearText();
            SNTextBox.Focus();
            LoadData();
        }

        private void DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SNTextBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            SATextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            SNUTextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            SETextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
