using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FYP___OrderManagementSystem
{
    public partial class NewAccount : Form
    {

        private SqlConnection _connection;
        private SqlCommand _command;
        //private SqlDataAdapter _sda;
        //private DataTable _dt;

        public NewAccount()
        {
            InitializeComponent();
        }

        private void CAButton_Click(object sender, EventArgs e)
        {
            string x = "", errormsg1 = "The following fields have been left blank;\n\n", errormsg2 = "\nPlease provide input and try again";
            int y = 0;
            if (string.IsNullOrWhiteSpace(FNTextBox.Text))
            {
                x += "Forename\n";
                y++;
            }
            if (string.IsNullOrWhiteSpace(SNTextBox.Text))
            {
                x += "Surname\n";
                y++;
            }
            if (string.IsNullOrWhiteSpace(DepTextBox.Text))
            {
                x += "Department\n";
                y++;
            }
            if (string.IsNullOrWhiteSpace(ALTextBox.Text))
            {
                x += "Access Level\n";
                y++;
            }
            if (y == 0)
            {
                AddAccount();
            }
            else
            {
                MessageBox.Show(errormsg1 + x + errormsg2);
            }
        }

        private void AddAccount()
        {
            string name = FNTextBox.Text + " " + SNTextBox.Text;
            string x = GenerateUN(FNTextBox.Text.ToLower(), DepTextBox.Text.ToUpper());
            _connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            _connection.Open();

            var sqlQuery = @"INSERT INTO[Users] ([Name], [Department], [UserName], [Password], [AccessLevel]) VALUES
                      ('" + name + "', '" + DepTextBox.Text + "', '" + x + "', '" + "default" + "', '" + ALTextBox.Text + "')";
            _command = new SqlCommand(sqlQuery, _connection);
            _command.ExecuteNonQuery();
            SNTextBox.Focus();
            
            _connection.Close();
        }
        
        private String GenerateUN(string name, string dep)
        {
            var rng = new Random();
            var username = name + dep.Substring(0, 3) + rng.Next(10) + rng.Next(10) + rng.Next(10);
            return username;
        }
    }
}
