using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FYP___OrderManagementSystem
{
    public partial class Login : Form
    {
        public static DateTime LogInTime { get; set; }
        public static string UserName { get; set; }
        public static int AccessLevel { get; set; }
        public static string Forename { get; set; }
        public static string PassWord { get; set; }
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
            var localDate = DateTime.Now;
            LogInTime = localDate;
            _connection = DB_Connect.connect();
            // Handles connection.Open() && connection.Close()
            _sda = new SqlDataAdapter(@"SELECT * FROM [FYP_DB].[dbo].[Users]
                Where UserName = '" + userName + "' and Password = '" + passWord + "'", _connection);
            _dt = new DataTable();
            _sda.Fill(_dt);

            if (_dt.Rows.Count == 1)
            {
                UserName = userName;
                PassWord = passWord;
                SetAccessLevel();
                MakeRecordOfLogin();
            }
            else
                MessageBox.Show(errorMessage1, error);
        }

        private void MakeRecordOfLogin()
        {
            _connection.Open();
            _command = new SqlCommand(@"INSERT INTO[Active Users] ([Username], [LoggedInAt]) VALUES
                             ('" + UserName + "', '" + LogInTime + "')", _connection);
            _command.ExecuteNonQuery();
            _connection.Close();
            Hide();
            var main = new MainMenu();
            main.Show();
        }

        private void SetAccessLevel()
        {
            _connection = DB_Connect.connect();
            _command = new SqlCommand(@"SELECT * FROM[Users] WHERE [Username] = '" + UserName + "'", _connection);
            try
            {
                _connection.Open();
                var myReader = _command.ExecuteReader();

                while (myReader.Read())
                {
                    AccessLevel = myReader.GetInt32(4);
                    Forename = myReader.GetString(0);
                    Forename = Forename.Substring(0, Forename.IndexOf(' ') + 1);
                }
                _connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
