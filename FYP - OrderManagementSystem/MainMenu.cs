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
        private SqlConnection _connection;
        private SqlCommand _command;
        private SqlDataAdapter _sda;
        private DataTable _dt;

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
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
            timer1.Interval = 20; // in miliseconds
            timer1.Start();
            if (MdiChildren.GetLength(0) > 0)
            {
                panel1.Visible = false;
                dataGridView2.Visible = false;
                label2.Visible = false;
                RefreshButton.Visible = false;
            }
            else
            {
                panel1.Visible = true;
                dataGridView2.Visible = true;
                label2.Visible = true;
                RefreshButton.Visible = true;
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            RefreshButton.BringToFront();
            dataGridView2.Visible = false;
            label2.Visible = false;
            timer1.Start();
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
            DateLabel.Text = DateTime.Now.ToLongDateString();
            dataGridView1.BackgroundColor = Color.White;
            dataGridView2.BackgroundColor = Color.White;
            InitTimer();
            LoadData();
        }

        private void LoadData()
        {
            var userName = Login.UserName;
            _connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            _connection.Open();
            dataGridView2.Visible = true;
            label2.Visible = true;
            _sda = new SqlDataAdapter(@"SELECT [OrderID], [Requestee], [OrderStatus] FROM[Orders] order by len(OrderID), OrderID", _connection);
            _dt = new DataTable();
            _sda.Fill(_dt);
            dataGridView2.Rows.Clear();
            //TimeLabel.Location = new Point(914, 498);

            foreach (DataRow item in _dt.Rows)
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = item["OrderID"].ToString();
                dataGridView2.Rows[n].Cells[1].Value = item["Requestee"].ToString();
                dataGridView2.Rows[n].Cells[2].Value = item["OrderStatus"].ToString();
            }
            char x = userName[userName.Length - 1];

            if (x == '3')
            {
                label2.Location = new Point(612, 69);
                RefreshButton.Location = new Point(712, 422);
                dataGridView2.Location = new Point(154, 87);
                productsToolStripMenuItem.Visible = false;
                manageOrdersToolStripMenuItem.Visible = false;
                accountManagementToolStripMenuItem.Visible = false;
                reportsToolStripMenuItem.Visible = false;
                suppliersToolStripMenuItem.Visible = false;
                dataGridView1.Visible = false;
                label1.Visible = false;
            }
            else
            {
                if (x == '2')
                {
                    manageOrdersToolStripMenuItem.Visible = false;
                }

                label2.Location = new Point(495, 69);
                RefreshButton.Location = new Point(595, 422);
                dataGridView2.Location = new Point(52, 87);
                _sda = new SqlDataAdapter(@"SELECT [ProductCode], [ProductStock] FROM[Products] WHERE [ProductStock] < 10 order by len(ProductCode), ProductCode", _connection);
                _dt = new DataTable();
                _sda.Fill(_dt);
                dataGridView1.Rows.Clear();

                foreach (DataRow item in _dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item["ProductCode"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item["ProductStock"].ToString();
                }
            }
            
            _connection.Close();
        }

        public void SimulateProduction()
        {
            //var x = "";
            var random = new Random();
            for (int n = 0; n < 4; n++)
            {
                var randomNumber = random.Next(1, GetTableSize() + 1);
                _connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
                _connection.Open();
                _command = new SqlCommand(@"UPDATE[Products] SET[ProductStock] -= 1 WHERE[ProductCode] =  + '" + randomNumber + "' AND [ProductStock] > 0", _connection);
                _command.ExecuteNonQuery();
                _connection.Close();
                _sda = new SqlDataAdapter(@"SELECT * FROM[Products] WHERE[ProductCode] =  + '" + randomNumber + "'", _connection);
                _dt = new DataTable();
                _sda.Fill(_dt);
                //TimeLabel.Location = new Point(914, 498);

                /*foreach (DataRow item in _dt.Rows)
                {
                    x += "" + item["ProductCode"] + "\n";
                }*/
            }

            //MessageBox.Show(x);
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

        private void ManageOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var orderManagement = new OrderManagement { MdiParent = this };
            orderManagement.Show();
        }

        private void SuppliersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var suppliers = new Suppliers { MdiParent = this };
            suppliers.Show();
        }

        public int GetTableSize()
        {
            const string stmt = "SELECT COUNT(*) FROM dbo.Products";
            int count;

            using (_connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True"))
            {
                using (var cmd = new SqlCommand(stmt, _connection))
                {
                    _connection.Open();
                    count = (int)cmd.ExecuteScalar();
                }
            }
            return count;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void RecordLogOut()
        {
            var localDate = DateTime.Now;
            var userName = Login.UserName;
            var logInTime = Login.LogInTime;
            _connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            _connection.Open();
            _command = new SqlCommand(@"UPDATE[Active] SET[LoggedOutAt] = '" + localDate + "' WHERE[Username] = '" + userName + "' AND [LoggedInAt] = '" + logInTime + "'", _connection);
            _command.ExecuteNonQuery();
            _connection.Close();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            RecordLogOut();
            Application.Exit();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            RecordLogOut();
            Application.Restart();
        }
    }
}
