using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FYP___OrderManagementSystem
{
    public partial class CreateOrder : Form
    {
        private string status = "Awaiting Authorisation";
        public static DateTime OrderTime { get; set; }
        public static int NumOfItems { get; set; }
        public static string OrderId { get; set; }
        public static string Quantity { get; set; }
        private SqlConnection _connection;
        private SqlCommand _command;
        private SqlDataAdapter _sda;
        private DataTable _dt;

        public CreateOrder()
        {
            InitializeComponent();
        }

        private void CreateOrder_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            FillComboBox();
            FillComboBox2();
            _connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            _sda = new SqlDataAdapter(@"SELECT * FROM[Products] order by len(ProductCode), ProductCode", _connection);
            _dt = new DataTable();
            _sda.Fill(_dt);
            dataGridView2.Rows.Clear();

            foreach (DataRow item in _dt.Rows)
            {
                var n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = item["ProductCode"].ToString();
                dataGridView2.Rows[n].Cells[1].Value = item["ProductName"].ToString();
                dataGridView2.Rows[n].Cells[2].Value = item["ProductSupplier"].ToString();
                dataGridView2.Rows[n].Cells[3].Value = item["ProductSupplierCode"].ToString();
                dataGridView2.Rows[n].Cells[4].Value = item["ProductPrice"].ToString();
                dataGridView2.Rows[n].Cells[5].Value = item["ProductStock"].ToString();
            }

            _sda = new SqlDataAdapter(@"SELECT * FROM[Cart]", _connection);
            _dt = new DataTable();
            _sda.Fill(_dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in _dt.Rows)
            {
                var n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["ProductCode"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["Quantity"].ToString();
            }
        }

        private void FillComboBox()
        {
            _connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            _command = new SqlCommand(@"SELECT * FROM[Products]", _connection);
            try
            {
                _connection.Open();
                var myReader = _command.ExecuteReader();

                while (myReader.Read())
                {
                    var pCode = myReader.GetString(0);
                    ProductCodeComboBox.Items.Add(pCode);
                }
                _connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillComboBox2()
        {
            _connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            _command = new SqlCommand(@"SELECT * FROM[Department]", _connection);
            try
            {
                _connection.Open();
                var myReader = _command.ExecuteReader();

                while (myReader.Read())
                {
                    var x = myReader.GetString(0);
                    DepComboBox.Items.Add(x);
                }
                _connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            const string error = "The quantity you have chosen exceeds the current stock level.\n\nPlease enter another quantity.";
            var quantity = Convert.ToInt32(QuantityUpDown.Text);
            var prodCode = ProductCodeComboBox.Text;
            _connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            _connection.Open();
            _sda = new SqlDataAdapter(@"SELECT * FROM[Products] WHERE[ProductCode] = '" + prodCode + "'", _connection);
            _dt = new DataTable();
            _sda.Fill(_dt);
            dataGridView1.Rows.Clear();

            if (_dt.Rows.Count == 1 && quantity != 0)
            {
                foreach (DataRow unused in _dt.Rows)
                {
                    NumOfItems = NumOfItems + 1;
                }

                _command = new SqlCommand(@"INSERT INTO[Cart]([ProductCode], [Quantity]) VALUES
                   ('" + prodCode + "', '" + quantity + "')", _connection);
                _command.ExecuteNonQuery();
                _sda = new SqlDataAdapter(@"SELECT * FROM[Cart]", _connection);
                _dt = new DataTable();
                _sda.Fill(_dt);
                dataGridView1.Rows.Clear();

                foreach (DataRow item in _dt.Rows)
                {
                    var n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item["ProductCode"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item["Quantity"].ToString();
                }
            }
            else
            {
                MessageBox.Show(error);
                QuantityUpDown.Value = 0;
                QuantityUpDown.Focus();
            }

            _sda.Dispose();
            _connection.Close();
        }

        private void DataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ProductCodeComboBox.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            QuantityUpDown.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
        }

        private static string GenerateRandomCode()
        {
            Random random = new Random();
            string result = "";
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            for (int i = 0; i < 8; i++)
            {
                int randomNumber = random.Next(0,35);
                result+= (chars[randomNumber]);
            }
            return result;
        }

        private double OrderTotal(string[,] array)
        {
            var connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            connection.Open();
            double oo = 0;
            for (int x = 0; x < array.Rank; x++)
            {
                var command = new SqlCommand("SELECT [ProductPrice] FROM[Products] WHERE [ProductCode] = '" + array[x,0] + "'", connection);
                var gg = (double) command.ExecuteScalar();
                var commandb = new SqlCommand("SELECT [Quantity] FROM[Cart] WHERE [ProductCode] = '" + array[x, 0] + "'", connection);
                var hh = (int)commandb.ExecuteScalar();
                oo += gg * hh;
            }

            connection.Close();
            return oo;
        }

        private void ClearText()
        {
            ProductCodeComboBox.SelectedIndex = -1;
            QuantityUpDown.Value = 0;
            DepComboBox.SelectedIndex = -1;
            RequesteeTextBox.Clear();
            ProductCodeComboBox.Focus();
        }

        private void SOButton_Click(object sender, EventArgs e)
        {
            const string stmt = "SELECT COUNT(*) FROM dbo.Cart";
            int count1 = 0;
            int count2 = 0;
            _connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            _connection.Open();
            _command = new SqlCommand(stmt, _connection);
            var count = (int)_command.ExecuteScalar();
            string[,] array = new string[count, count];
            var command1 = new SqlCommand(@"SELECT * FROM[Cart]", _connection);
            _connection.Close();

            try
            {
                _connection.Open();
                var myReader = command1.ExecuteReader();

                array = new string[count, count];

                while (myReader.Read())
                {
                    array[count1, count2] = myReader.GetString(0);
                    count2++;
                    array[count1, count2] = Convert.ToString(myReader.GetInt32(1));
                    count2--;
                    count1++;
                }
                _connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            double jj = Math.Round(OrderTotal(array),2);
            var localDate = DateTime.Now;
            OrderTime = localDate;
            var error = "dialog box empty. Please fill before submitting";

            if (DepComboBox.Text == "")
            {
                MessageBox.Show("Department " + error);
                DepComboBox.Focus();
            }
            else if (RequesteeTextBox.Text == "")
            {
                MessageBox.Show("Requestee " + error);
                RequesteeTextBox.Focus();
            }
            else
            {
                var randCode = GenerateRandomCode();
                _connection.Open();
                _command = new SqlCommand("INSERT IntO[Orders]([OrderID],[NumberOfItems],[Department],[Requestee],[OrderDate],[OrderStatus],[OrderTotal]) VALUES" +
                                                    "('" + randCode + "', '" + NumOfItems + "', '" + DepComboBox.Text + "', '" + RequesteeTextBox.Text + "', '" + localDate + "', '" + status + "', '" + jj + "')", _connection);
                _command.ExecuteNonQuery();
                _command = new SqlCommand("SELECT * FROM[Cart] DELETE FROM[Cart]", _connection);
                _command.ExecuteNonQuery();
                _connection.Close();
                ClearText();
                dataGridView1.Rows.Clear();
                NumOfItems = 0;
                MessageBox.Show(
                    "Your order has been submitted!\n\nPlease view the orders board to check status of your order.\n\nTake note of your Order ID, you'll need it to keep track of your order!\n\n\t\tOrder ID = " +
                    randCode + "");
                notifyIcon1.ShowBalloonTip(1000, "Important notification", "Something important", ToolTipIcon.Info);
            }
        }

        private void CreateOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            _connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            _connection.Open();
            _command = new SqlCommand("SELECT * FROM[Cart] DELETE FROM[Cart]", _connection);
            _command.ExecuteNonQuery();
            _connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            _connection.Open();
            var sqlQuery = @"DELETE FROM[Cart] WHERE[ProductCode] = '" + dataGridView1.Rows[0].Cells[0].Value + "'";
            _command = new SqlCommand(sqlQuery, _connection);
            _command.ExecuteNonQuery();
            _connection.Close();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
        }
    }
}
