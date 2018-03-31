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
            Thread.Sleep(5000);

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
            timer1.Interval = 1; // in miliseconds
            timer1.Start();

            if (MdiChildren.GetLength(0) > 0)
            {
                MenuDisplayChange(false);
            }
            else
            {
                MenuDisplayChange(true);
            }
        }

        private void MenuDisplayChange(bool denoter)
        {
            if (Login.AccessLevel != 3)
            {
                dataGridView1.Visible = denoter;
                label1.Visible = denoter;
            }
            dataGridView2.Visible = denoter;
            label2.Visible = denoter;
            TimeLabel.Visible = denoter;
            DateLabel.Visible = denoter;
            LogoutButton.Visible = denoter;
            RefreshButton.Visible = denoter;
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
            if (Login.PassWord == "default")
            {
                ChangePassword cpw = new ChangePassword { MdiParent = this };
                cpw.Show();
            }
            LoadData();
            timer1.Start();
            DateLabel.Text = DateTime.Now.ToLongDateString();
            InitTimer();
        }

        private void FilterMenuFeatures()
        {
            _connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            _connection.Open();
            _sda = new SqlDataAdapter(@"SELECT [OrderID], [Requestee], [OrderStatus] FROM[Orders] order by len(OrderID), OrderID", _connection);
            _dt = new DataTable();
            _sda.Fill(_dt);
            dataGridView2.Rows.Clear();

            foreach (DataRow item in _dt.Rows)
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = item["OrderID"].ToString();
                dataGridView2.Rows[n].Cells[1].Value = item["Requestee"].ToString();
                dataGridView2.Rows[n].Cells[2].Value = item["OrderStatus"].ToString();
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

        private void SuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var suppliers = new Suppliers { MdiParent = this };
            suppliers.Show();
        }

        private void LogGRNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lGRN = new LogGRN();// { MdiParent = this };
            lGRN.Show();
        }
        
        private void existingAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var existingAcc = new ExistingAccount();
            existingAcc.Show();
        }

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newAcc = new NewAccount();
            newAcc.Show();
        }

        private void OPEBarCToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var empOrdersBarChart = new EmpOrdersBarChart();
            empOrdersBarChart.Show();
        }

        private void OPEPieCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var empOrdersPieChart = new EmpOrdersPieChart();
            empOrdersPieChart.Show();
        }

        private void OPDBarCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var depOrdersBarChart = new DepOrdersBarChart();
            depOrdersBarChart.Show();
        }

        private void OPDPieCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var empOrdersPieChart = new EmpOrdersPieChart();
            empOrdersPieChart.Show();
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
