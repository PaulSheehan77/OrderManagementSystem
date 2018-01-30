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
            var errorMessage = "Invalid login details supplied";
            var error = "Error";
            var localDate = DateTime.Now;
            LogInTime = localDate;
            var connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            // Handles connection.Open() && connection.Close()
            var sda = new SqlDataAdapter(@"SELECT * FROM [FYP_DB].[dbo].[Login]
                Where UserName = '"+ unTextBox.Text +"' and Password = '"+ pwTextBox.Text +"'", connection);
            var dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                UserName = unTextBox.Text;
                connection.Open();
                var command = new SqlCommand(@"INSERT INTO[Active] ([Username], [LoggedInAt]) VALUES
                             ('" + UserName + "', '" + localDate +"')", connection);
                command.ExecuteNonQuery();
                connection.Close();
                Hide();
                unTextBox.Clear();
                pwTextBox.Clear();
                unTextBox.Focus();
                var main = new MainMenu();
                main.Show();
            }
            else
            {
                MessageBox.Show(errorMessage, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                unTextBox.Clear();
                pwTextBox.Clear();
                unTextBox.Focus();
                // 38.43
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
