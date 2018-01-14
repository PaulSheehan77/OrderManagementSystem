using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYP___OrderManagementSystem
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM[Products]", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["ProductCode"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["ProductName"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["ProductSupplier"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["ProductSupplierCode"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["ProductPrice"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["ProductStock"].ToString();
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

        private bool IfProductExists(SqlConnection connection, string prodCode)
        {
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT 1 FROM[Products] WHERE[ProductCode] = '" + prodCode + "'", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public void clearText()
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
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            connection.Open();
            var sqlQuery = "";
            
            if (IfProductExists(connection, PCTextBox.Text))
            {
                MessageBox.Show("An item with this product code already exists.\n\nPlease enter a different product code.");
                PCTextBox.Clear();
                PCTextBox.Focus();
            }
            else
            {
                /*if (!CheckOrdering(connection, (Convert.ToInt32(PCTextBox.Text))))
                {
                    MessageBox.Show("Invalid product code entered.\n\nPlease enter a product code that it +1 to the last product code entered.");
                    PCTextBox.Clear();
                    PCTextBox.Focus();
                }
                else
                {*/
                    sqlQuery = @"INSERT INTO[Products] ([ProductCode], [ProductName], [ProductSupplier], [ProductSupplierCode], [ProductPrice], [ProductStock]) VALUES
                             ('" + PCTextBox.Text + "', '" + PNTextBox.Text + "', '" + SNTextBox.Text + "', '" + SCTextBox.Text + "', '" + PriceTextBox.Text + "', '" + StockTextBox.Text + "')";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.ExecuteNonQuery();
                    clearText();
                    PCTextBox.Focus();
                //}
            }

            connection.Close();

            LoadData();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            connection.Open();

            if (IfProductExists(connection, PCTextBox.Text))
            {
                var sqlQuery = @"UPDATE[Products] SET[ProductName] = '" + PNTextBox.Text + "', [ProductSupplier] = '" + SNTextBox.Text + "' , [ProductSupplierCode] = '" + SCTextBox.Text + "', [ProductPrice] = '" + PriceTextBox.Text + "', [ProductStock] = '" + StockTextBox.Text + "' WHERE[ProductCode] = '" + PCTextBox.Text + "'";
                clearText();
                PCTextBox.Focus();
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("An item with this product code doesn't exist.\n\nPlease enter a different product code.");
                PCTextBox.Clear();
                PCTextBox.Focus();
            }
            
            connection.Close();

            LoadData();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");

            if (IfProductExists(connection, PCTextBox.Text))
            {
                int rowIndex;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(PCTextBox.Text))
                    {
                        rowIndex = row.Index;
                        dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }

                PCTextBox.Focus();
            }
            else
            {
                MessageBox.Show("This item does not exist!");
                clearText();
                PCTextBox.Focus();
            }
            LoadData();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            var sqlQuery = "";

            if (IfProductExists(connection, PCTextBox.Text))
            {
                connection.Open();
                sqlQuery = @"DELETE FROM[Products] WHERE[ProductCode] = '" + PCTextBox.Text + "'";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                MessageBox.Show("This item does not exist!");
            }

            clearText();
            PCTextBox.Focus();
            LoadData();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PCTextBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            PNTextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            SNTextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            SCTextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            PriceTextBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            StockTextBox.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
