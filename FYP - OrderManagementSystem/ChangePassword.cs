using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FYP___OrderManagementSystem
{
    public partial class ChangePassword : Form
    {
        private SqlConnection _connection;
        private SqlCommand _command;

        public ChangePassword()
        {
            InitializeComponent();
            BringToFront();
            LoadData();
        }

        public void LoadData()
        {
            label1.Text = "Welcome " + Login.Forename + "!";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var error = "Passwords do not match. Please try again.";
            var error2 = "Password does not contain at least 6 letters. Please try again.";
            var success = "Password successfully changed!";

            if (textBox1.Text == textBox2.Text)
            {
                if (textBox1.Text.Length < 6)
                {
                    MessageBox.Show(error2);
                }
                else
                {
                    _connection = DB_Connect.connect();
                    _connection.Open();
                    var sqlQuery = @"UPDATE[Users] SET[Password] = '" + textBox2.Text + "' WHERE [UserName] = '" + Login.UserName + "'";
                    _command = new SqlCommand(sqlQuery, _connection);
                    _command.ExecuteNonQuery();
                    _connection.Close();
                    Close();
                    MessageBox.Show(success);
                }
            }
            else
            {
                MessageBox.Show(error);
            }
        }
    }
}
