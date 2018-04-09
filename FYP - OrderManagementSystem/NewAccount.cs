using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FYP___OrderManagementSystem
{
    public partial class NewAccount : Form
    {
        private SqlConnection _connection;
        private SqlCommand _command;

        public NewAccount()
        {
            InitializeComponent();

            DEPcb.Items.Add(Constants.alu); DEPcb.Items.Add(Constants.gla); DEPcb.Items.Add(Constants.pine); DEPcb.Items.Add(Constants.pvc); DEPcb.Items.Add("Accounting"); DEPcb.Items.Add(Constants.pur);
            DEPcb.Items.Add(Constants.teak); ALcb.Items.Add("1"); ALcb.Items.Add("2"); ALcb.Items.Add("3");
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
            if (string.IsNullOrWhiteSpace(DEPcb.Text))
            {
                x += Constants.dep + "\n";
                y++;
            }
            if (string.IsNullOrWhiteSpace(ALcb.Text))
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
            string x = GenerateUN(FNTextBox.Text.ToLower(), DEPcb.Text.ToUpper());
            var success = "You have successfully created an account!\n\nYour username is : " + x + "\nYour password is : default\n\nThis can be changed when you log in for the first time.";
            _connection = DB_Connect.connect();
            _connection.Open();

            var sqlQuery = @"INSERT INTO[Users] ([Name], [Department], [UserName], [Password], [AccessLevel]) VALUES
                      ('" + name + "', '" + DEPcb.Text + "', '" + x + "', '" + "default" + "', '" + ALcb.Text + "')";
            _command = new SqlCommand(sqlQuery, _connection);
            _command.ExecuteNonQuery();
            FNTextBox.Clear();
            SNTextBox.Clear();
            DEPcb.SelectedIndex = -1;
            ALcb.SelectedIndex = -1;
            FNTextBox.Focus();
            MessageBox.Show(success);
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
