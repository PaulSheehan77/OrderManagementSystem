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
    public partial class MainMenu : Form
    {
        private Timer timer;
        private int[] productsWithLowStock;
        private int yup = 0;
        public MainMenu()
        {
            InitializeComponent();
        }

        public void InitTimer()
        {
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 20000; // in miliseconds
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            SimulateProduction();
            //CheckLowStock();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DateTime localDate = DateTime.Now;
            var userName = Login.UserName;
            DateTime logInTime = Login.LogInTime;
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand(@"UPDATE[Active] SET[LoggedOutAt] = '" + localDate + "' WHERE[LoggedInAt] = '" + logInTime + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            Application.Exit();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.MdiParent = this;
            products.Show();
        }

        public int GetTableSize()
        {
            string stmt = "SELECT COUNT(*) FROM dbo.Products";
            int count = 0;

            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand(stmt, connection))
                {
                    connection.Open();
                    count = (int)cmd.ExecuteScalar();
                }
            }
            return count;
        }

        /*public void CheckLowStock()
        {
            string stmt = "SELECT [ProductCode] FROM [dbo].[Products] WHERE [ProductStock] < 10";

            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True"))
            {
                int count = 0;
                SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM [dbo].[Products] WHERE[ProductStock] < 10", connection);
                connection.Open();
                count = (int)cmd1.ExecuteScalar();
                productsWithLowStock = new int[count];
                connection.Close();

                using (SqlCommand cmd = new SqlCommand(stmt, connection))
                {
                    SqlDataAdapter sda = new SqlDataAdapter(@"SELECT[ProductCode] FROM[dbo].[Products] WHERE[ProductStock] < 10", connection);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        connection.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                while (yup < productsWithLowStock.Length)
                                {
                                    productsWithLowStock[yup] = reader.GetInt32(0);
                                }
                                yup++;
                            }
                            reader.Close();
                        }
                        connection.Close();

                        String result = "The following products have low stock\n";
                        for (int j = 0; j < productsWithLowStock.Length; j++)
                        {
                            result += "\n" + productsWithLowStock[j];
                        }

                        MessageBox.Show(result);
                    }
                    else
                    {
                        MessageBox.Show("Boo");
                    }
                }
            }
        }*/

        public void SimulateProduction()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, GetTableSize()+1);

            SqlConnection connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            connection.Open();

            var sqlQuery = @"UPDATE[Products] SET[ProductStock] -= 1 WHERE[ProductCode] =  + '" + randomNumber + "'";
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            command.ExecuteNonQuery();

            connection.Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            timer1.Start();
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
            DateLabel.Text = DateTime.Now.ToLongDateString();
            label1.BackColor = Color.Transparent;
            dataGridView1.BackgroundColor = Color.White;
            InitTimer();
            LoadData();
        }

        private void LoadData()
        {
            var userName = Login.UserName;
            if (userName == "factory")
            {
                productsToolStripMenuItem.Visible = false;
                manageOrdersToolStripMenuItem.Visible = false;
                accountManagementToolStripMenuItem.Visible = false;
                reportsToolStripMenuItem.Visible = false;
                suppliersToolStripMenuItem.Visible = false;
                dataGridView1.Visible = false;
                label1.Visible = false;
                RefreshButton.Visible = false;
            }
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT [ProductCode], [ProductStock] FROM[Products] WHERE [ProductStock] < 10", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["ProductCode"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["ProductStock"].ToString();
                /*if ((bool)item["ProductStatus"])
                {
                    dataGridView1.Rows[n].Cells[2].Value = "Active";
                }
                else
                {
                    dataGridView1.Rows[n].Cells[2].Value = "Deactive";
                }*/
            }

            connection.Close();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
