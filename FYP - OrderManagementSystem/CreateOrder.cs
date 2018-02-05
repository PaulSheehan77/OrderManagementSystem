using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FYP___OrderManagementSystem
{
    public partial class CreateOrder : Form
    {
        private string status = "Deactive";
        public static DateTime OrderTime { get; set; }
        public static int NumOfItems { get; set; }
        public static string OrderId { get; set; }
        public static string Quantity { get; set; }

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
            var connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            var sda = new SqlDataAdapter(@"SELECT * FROM[Products]", connection);
            var dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                var n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = item["ProductCode"].ToString();
                dataGridView2.Rows[n].Cells[1].Value = item["ProductName"].ToString();
                dataGridView2.Rows[n].Cells[2].Value = item["ProductSupplier"].ToString();
                dataGridView2.Rows[n].Cells[3].Value = item["ProductSupplierCode"].ToString();
                dataGridView2.Rows[n].Cells[4].Value = item["ProductPrice"].ToString();
                dataGridView2.Rows[n].Cells[5].Value = item["ProductStock"].ToString();
            }
        }

        private void FillComboBox()
        {
            var connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            var command = new SqlCommand(@"SELECT * FROM[Products]", connection);
            try
            {
                connection.Open();
                var myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    var pCode = myReader.GetString(0);
                    ProductCodeComboBox.Items.Add(pCode);
                }
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillComboBox2()
        {
            var connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            var command = new SqlCommand(@"SELECT * FROM[Department]", connection);
            try
            {
                connection.Open();
                var myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    var x = myReader.GetString(0);
                    DepComboBox.Items.Add(x);
                }
                connection.Close();
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
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM[Products] WHERE[ProductCode] = '" + prodCode + "'", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            if (dt.Rows.Count == 1 && quantity != 0)
            {
                var command = new SqlCommand(@"INSERT INTO[Cart]([ProductCode], [Quantity]) VALUES
                   ('" + prodCode + "', '" + quantity + "')", connection);
                command.ExecuteNonQuery();
                var sdaB = new SqlDataAdapter(@"SELECT * FROM[Cart]", connection);
                var dtB = new DataTable();
                sdaB.Fill(dtB);
                dataGridView1.Rows.Clear();

                foreach (DataRow unused in dt.Rows)
                {
                    NumOfItems = NumOfItems + 1;
                }

                foreach (DataRow item in dtB.Rows)
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

            sda.Dispose();
            connection.Close();
        }

        private void DataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ProductCodeComboBox.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            QuantityUpDown.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void CreateOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM[Cart] DELETE FROM[Cart]", connection);
            command.ExecuteNonQuery();
            connection.Close();
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
            var connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            connection.Open();
            var cmd = new SqlCommand(stmt, connection);
            var count = (int)cmd.ExecuteScalar();
            string[,] array = new string[count, count];
            var command1 = new SqlCommand(@"SELECT * FROM[Cart]", connection);
            connection.Close();

            try
            {
                connection.Open();
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
                connection.Close();
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
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT IntO[Orders]([OrderID],[NumberOfItems],[Department],[Requestee],[OrderDate],[OrderStatus],[OrderTotal]) VALUES" +
                                                    "('" + randCode + "', '" + NumOfItems + "', '" + DepComboBox.Text + "', '" + RequesteeTextBox.Text + "', '" + localDate + "', '" + status + "', '" + jj + "')", connection);
                command.ExecuteNonQuery();
                SqlCommand commandB = new SqlCommand("SELECT * FROM[Cart] DELETE FROM[Cart]", connection);
                commandB.ExecuteNonQuery();
                connection.Close();
                ClearText();
                dataGridView1.Rows.Clear();
                NumOfItems = 0;
                MessageBox.Show(
                    "Your order has been submitted!\n\nPlease check the orders board to check status of your order.\n\nTake note of your Order ID, you'll need it to keep track of your order!\n\nOrder ID = " +
                    randCode + "");
            }
        }
    }
}
