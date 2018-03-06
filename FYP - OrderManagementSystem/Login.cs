using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace FYP___OrderManagementSystem
{
    public partial class Login : Form
    {
        public static DateTime LogInTime { get; set; }
        public static string UserName { get; set; }
        public static string AccessLevel { get; set; }
        private SqlConnection _connection;
        private SqlCommand _command;
        private SqlDataAdapter _sda;
        private DataTable _dt;

        public Login()
        {
            InitializeComponent();
        }

        public void Login_Load(object sender, EventArgs e)
        {
            unLabel.BackColor = Color.Transparent;
            pwLabel.BackColor = Color.Transparent;
            forgotPWLink.BackColor = Color.Transparent;
        }

        private void ClearUNButton_Click(object sender, EventArgs e)
        {
            unTextBox.Clear();
            unTextBox.Focus();
        }

        private void ClearPWButton_Click(object sender, EventArgs e)
        {
            pwTextBox.Clear();
            pwTextBox.Focus();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            CheckLogInAuthenticity(unTextBox.Text, pwTextBox.Text);
        }

        public void CheckLogInAuthenticity(string userName, string passWord)
        {
            var errorMessage1 = "Invalid login details supplied.\n\nPlease try again.";
            var error = "Error";
            var x = "";
            var localDate = DateTime.Now;
            LogInTime = localDate;
            _connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            // Handles connection.Open() && connection.Close()
            _sda = new SqlDataAdapter(@"SELECT * FROM [FYP_DB].[dbo].[Login]
                Where UserName = '" + userName + "' and Password = '" + passWord + "'", _connection);
            _dt = new DataTable();
            _sda.Fill(_dt);

            if (_dt.Rows.Count == 1)
            {
                UserName = userName;
                _connection.Open();
                _command = new SqlCommand(@"INSERT INTO[Active] ([Username], [LoggedInAt]) VALUES
                             ('" + userName + "', '" + localDate + "')", _connection);
                _command.ExecuteNonQuery();
                _connection.Close();
                Hide();
                pwTextBox.Clear();
                unTextBox.Clear();
                unTextBox.Focus();
                var main = new MainMenu();
                main.Show();
            }
            else
                throw new ArgumentException(errorMessage1, error);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
