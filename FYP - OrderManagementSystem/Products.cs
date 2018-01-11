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

        private void AddButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            connection.Open();
            var sqlQuery = "";
            
            if (IfProductExists(connection, PCTextBox.Text))
            {
                sqlQuery = @"UPDATE[Products] SET[ProductName] = '" + PNTextBox.Text + "', [ProductSupplier] = '" + SNTextBox.Text + "' , [ProductSupplierCode] = '" + SCTextBox.Text + "', [ProductPrice] = '" + PriceTextBox.Text + "' WHERE[ProductCode] = '" + PCTextBox.Text + "'";
            }
            else
            {
                sqlQuery = @"INSERT INTO[Products] ([ProductCode], [ProductName], [ProductSupplier], [ProductSupplierCode], [ProductPrice]) VALUES
                             ('" + PCTextBox.Text + "', '" + PNTextBox.Text + "', '" + SNTextBox.Text + "', '" + SCTextBox.Text + "', '" + PriceTextBox.Text + "')";
            }

            SqlCommand command = new SqlCommand(sqlQuery, connection);
            command.ExecuteNonQuery();
            connection.Close();

            LoadData();
            PCTextBox.Focus();
            clearText();
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

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PCTextBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            PNTextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            SNTextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            SCTextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            PriceTextBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        public void clearText()
        {
            PCTextBox.Clear();
            PNTextBox.Clear();
            SNTextBox.Clear();
            SCTextBox.Clear();
            PriceTextBox.Clear();
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

            LoadData();
            PCTextBox.Focus();
            clearText();
        }
    }
}
