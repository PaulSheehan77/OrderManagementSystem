using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace FYP___OrderManagementSystem
{
    public partial class MainMenu : Form
    {
        private Timer _timer;

        public MainMenu()
        {
            InitializeComponent();
        }

        public void InitTimer()
        {
            _timer = new Timer();
            _timer.Tick += Timer_Tick;
            _timer.Interval = 20000; // in miliseconds
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            SimulateProduction();
            //CheckLowStock();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
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

        public void SimulateProduction()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, GetTableSize() + 1);
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand(@"UPDATE[Products] SET[ProductStock] -= 1 WHERE[ProductCode] =  + '" + randomNumber + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void ProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var products = new Products {MdiParent = this};
            products.Show();
        }

        private void CreateOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var createOrder = new CreateOrder {MdiParent = this};
            createOrder.Show();
        }

        public int GetTableSize()
        {
            const string stmt = "SELECT COUNT(*) FROM dbo.Products";
            int count;

            using (var connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True"))
            {
                using (var cmd = new SqlCommand(stmt, connection))
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

       private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            var localDate = DateTime.Now;
            var userName = Login.UserName;
            var logInTime = Login.LogInTime;
            var connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            connection.Open();
            var command = new SqlCommand(@"UPDATE[Active] SET[LoggedOutAt] = '" + localDate + "' WHERE[Username] = '" + userName + "' AND [LoggedInAt] = '" + logInTime + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            Application.Exit();
        }
    }
}
