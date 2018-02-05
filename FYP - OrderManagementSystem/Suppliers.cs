using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FYP___OrderManagementSystem
{
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            var connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            var sda = new SqlDataAdapter(@"SELECT * FROM[Suppliers]", connection);
            var dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                var n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["SupplierName"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["SupplierAddress"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["SupplierNumber"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["SupplierEmail"].ToString();
            }
        }

        private static bool IfSupplierExists(SqlConnection connection, string supplierName)
        {
            var sda = new SqlDataAdapter(@"SELECT 1 FROM[Suppliers] WHERE[SupplierName] = '" + supplierName + "'", connection);
            var dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
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
            var connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            connection.Open();

            if (IfSupplierExists(connection, SNTextBox.Text))
            {
                MessageBox.Show(errorMessage);
                SNTextBox.Clear();
                SNTextBox.Focus();
            }
            else
            {
                var sqlQuery = @"INSERT INTO[Suppliers] ([SupplierName], [SupplierAddress], [SupplierNumber], [SupplierEmail]) VALUES
                      ('" + SNTextBox.Text + "', '" + SATextBox.Text + "', '" + SNUTextBox.Text + "', '" + SETextBox.Text + "')";
                var command = new SqlCommand(sqlQuery, connection);
                command.ExecuteNonQuery();
                ClearText();
                SNTextBox.Focus();
            }

            connection.Close();
            LoadData();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            const string errorMessage = "A supplier with this name doesn't exist.\n\nPlease enter a different name.";
            var connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            connection.Open();

            if (IfSupplierExists(connection, SNTextBox.Text))
            {
                var sqlQuery = @"UPDATE[Suppliers] SET[SupplierName] = '" + SNTextBox.Text + "', [SupplierAddress] = '" + SATextBox.Text + "' , [SupplierNumber] = '" + SNUTextBox.Text + "', [SupplierEmail] = '" + SETextBox.Text + "' WHERE[SupplierName] = '" + SNTextBox.Text + "'";
                ClearText();
                SNTextBox.Focus();
                var command = new SqlCommand(sqlQuery, connection);
                command.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show(errorMessage);
                SNTextBox.Clear();
                SNTextBox.Focus();
            }

            connection.Close();
            LoadData();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            const string errorMessage = "This supplier does not exist!";
            var connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");

            if (IfSupplierExists(connection, SNTextBox.Text))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.Cells[1].Value.ToString().Equals(SNTextBox.Text)) continue;
                    dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
                SNTextBox.Focus();
            }
            else
            {
                MessageBox.Show(errorMessage);
                ClearText();
                SNTextBox.Focus();
            }

            LoadData();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            const string errorMessage = "This supplier does not exist!";
            var connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");

            if (IfSupplierExists(connection, SNTextBox.Text))
            {
                connection.Open();
                var sqlQuery = @"DELETE FROM[Suppliers] WHERE[SupplierName] = '" + SNTextBox.Text + "'";
                var command = new SqlCommand(sqlQuery, connection);
                command.ExecuteNonQuery();
                connection.Close();
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
