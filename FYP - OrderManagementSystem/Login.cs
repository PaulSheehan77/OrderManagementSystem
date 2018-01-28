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
    public partial class Login : Form
    {
        private string userName;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            unLabel.BackColor = Color.Transparent;
            pwLabel.BackColor = Color.Transparent;
            forgotPWLink.BackColor = Color.Transparent;
        }

        private void SetUserName(string userName)
        {
            this.userName = userName;
        }

        public string GetUserName()
        {
            return userName;
        }

        private void clearUNButton_Click(object sender, EventArgs e)
        {
            unTextBox.Clear();
            unTextBox.Focus();
        }

        private void clearPWButton_Click(object sender, EventArgs e)
        {
            pwTextBox.Clear();
            pwTextBox.Focus();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            // Handles connection.Open() && connection.Close()
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [FYP_DB].[dbo].[Login]
                Where UserName = '"+ unTextBox.Text +"' and Password = '"+ pwTextBox.Text +"'", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                SetUserName(unTextBox.Text);
                connection.Open();
                SqlCommand command = new SqlCommand(@"INSERT INTO[Active] ([Username], [LoggedInAt]) VALUES
                             ('" + GetUserName() + "', '" + localDate +"')", connection);
                command.ExecuteNonQuery();
                connection.Close();
                this.Hide();
                MainMenu main = new MainMenu();
                main.Show();
            }
            else
            {
                MessageBox.Show("Invalid login details supplied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                unTextBox.Clear();
                pwTextBox.Clear();
                unTextBox.Focus();
                // 38.43
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
