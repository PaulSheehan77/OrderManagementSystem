using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;
using FYP___OrderManagementSystem.Reports;
using Timer = System.Windows.Forms.Timer;

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
            var t = new Thread(SplashStart);
            t.Start();
            Thread.Sleep(5000); // in miliseconds

            InitializeComponent();
            t.Abort();
        }

        public void SplashStart()
        {
            Application.Run(new Loading());
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
        }

        private void MenuFeatureChange(bool denoter)
        {
            dataGridView1.Visible = denoter;
            label1.Visible = denoter;
            productsToolStripMenuItem.Visible = denoter;
            manageOrdersToolStripMenuItem.Visible = denoter;
            accountManagementToolStripMenuItem.Visible = denoter;
            ReportsToolStripMenuItem.Visible = denoter;
            suppliersToolStripMenuItem.Visible = denoter;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (Login.AccessLevel == 3)
            {
                dataGridView1.Visible = false;
                label1.Visible = false;
            }
            LoadData();
            Timer1.Start();
            DateLabel.Text = DateTime.Now.ToLongDateString();
            InitTimer();

            if (Login.PassWord == "default")
            {
                ChangePassword cpw = new ChangePassword();
                cpw.TopMost = true;
                cpw.Show();
            }
        }

        private void FilterMenuFeatures()
        {
            _connection = DB_Connect.connect();
            _connection.Open();
            _sda = new SqlDataAdapter(@"SELECT * FROM[Orders] order by len(OrderDate), OrderDate", _connection);
            _dt = new DataTable();
            _sda.Fill(_dt);
            dataGridView2.Rows.Clear();

            foreach (DataRow item in _dt.Rows)
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = item["OrderID"].ToString();
                dataGridView2.Rows[n].Cells[1].Value = item[Constants.req].ToString();
                dataGridView2.Rows[n].Cells[2].Value = item["OrderStatus"].ToString();
                dataGridView2.Rows[n].Cells[3].Value = item["OrderDate"].ToString();
            }

            if (Login.AccessLevel == 3)
            {
                MenuFeatureChange(false);
            }
            else
            {
                if (Login.AccessLevel == 2)
                {
                    manageOrdersToolStripMenuItem.Visible = false;
                    accountManagementToolStripMenuItem.Visible = false;
                }
                
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

        private void LoadData()
        {
            FilterMenuFeatures();
        }

        public void SimulateProduction()
        {
            var random = new Random();
            for (int n = 0; n < 4; n++)
            {
                var randomNumber = random.Next(1, GetTableSize() + 1);
                _connection = DB_Connect.connect();
                _connection.Open();
                _command = new SqlCommand(@"UPDATE[Products] SET[ProductStock] -= 1 WHERE[ProductCode] =  + '" + randomNumber + "' AND [ProductStock] > 0", _connection);
                _command.ExecuteNonQuery();
                _connection.Close();
                _sda = new SqlDataAdapter(@"SELECT * FROM[Products] WHERE[ProductCode] =  + '" + randomNumber + "'", _connection);
                _dt = new DataTable();
                _sda.Fill(_dt);
            }
        }

        private void ProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var products = new Products();
            products.TopMost = true;
            products.Show();
        }

        private void CreateOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var createOrder = new CreateOrder();
            createOrder.TopMost = true;
            createOrder.Show();
        }

        private void ManageOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var orderManagement = new OrderManagement();
            orderManagement.TopMost = true;
            orderManagement.Show();
        }

        private void SuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var suppliers = new Suppliers();
            suppliers.Show();
        }

        private void LogGRNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lGRN = new LogGRN();
            lGRN.TopMost = true;
            lGRN.Show();
        }
        
        private void ExistingAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var existingAcc = new ExistingAccount();
            existingAcc.TopMost = true;
            existingAcc.Show();
        }

        private void NewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newAcc = new NewAccount();
            newAcc.TopMost = true;
            newAcc.Show();
        }

        private void ReportsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var cv = new ChartView();
            cv.TopMost = true;
            cv.Show();
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
            _connection = DB_Connect.connect();
            _connection.Open();
            _command = new SqlCommand(@"UPDATE[Active Users] SET[LoggedOutAt] = '" + localDate + "' WHERE[Username] = '" + userName + "' AND [LoggedInAt] = '" + logInTime + "'", _connection);
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
