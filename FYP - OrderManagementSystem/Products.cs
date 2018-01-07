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
            StatusComboBox.SelectedIndex = 0;
            LoadData();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            // Insert Logic
            connection.Open();
            bool status;
            if (StatusComboBox.SelectedIndex == 0)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            SqlCommand command = new SqlCommand(@"INSERT INTO [dbo].[Products]
                        ([ProductCode]
                    ,[ProductName]
                ,[ProductStatus])
            VALUES
                ('" + PCTextBox.Text + "', '" + PNTextBox.Text + "', '" + status +"')", connection);
            command.ExecuteNonQuery();
            connection.Close();

            LoadData();
        }

        public void LoadData()
        {
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT [ProductCode]
                    ,[ProductName]
                ,[ProductStatus]
            FROM[dbo].[Products]", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["ProductCode"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["ProductName"].ToString();
                if ((bool)item["ProductStatus"])
                {
                    dataGridView1.Rows[n].Cells[2].Value = "Active";
                }
                else
                {
                    dataGridView1.Rows[n].Cells[2].Value = "Deactive";
                }
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PCTextBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            PNTextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "Active")
            {
                StatusComboBox.SelectedIndex = 0;
            }
            else
            {
                StatusComboBox.SelectedIndex = 1;
            }
        }
    }
}
