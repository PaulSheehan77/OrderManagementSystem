﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FYP___OrderManagementSystem
{
    public partial class ExistingAccount : Form
    {
        private SqlConnection _connection;
        private SqlCommand _command;
        private SqlDataAdapter _sda;
        private DataTable _dt;

        public ExistingAccount()
        {
            InitializeComponent();

            DEPcb.Items.Add(Constants.alu); DEPcb.Items.Add(Constants.gla); DEPcb.Items.Add(Constants.pine); DEPcb.Items.Add(Constants.pvc); DEPcb.Items.Add("Accounting"); DEPcb.Items.Add(Constants.pur);
            DEPcb.Items.Add(Constants.teak); ALcb.Items.Add("1"); ALcb.Items.Add("2"); ALcb.Items.Add("3");
            LoadData();
        }

        public void LoadData()
        {
            FillComboBox2();
            _connection = DB_Connect.connect();
            _sda = new SqlDataAdapter(@"SELECT * FROM[Users] order by UserName", _connection);
            _dt = new DataTable();
            _sda.Fill(_dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow item in _dt.Rows)
            {
                var n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["UserName"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[Constants.dep].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["AccessLevel"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["Password"].ToString();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var error = "Password entered is too short. Please enter a password with 6 characters or more.";
            _connection = DB_Connect.connect();
            _connection.Open();

            if (PWTextBox.Text.Length > 1 && PWTextBox.Text.Length < 6)
            {
                MessageBox.Show(error);
            }
            else
            {
                var sqlQuery = @"UPDATE[Users] SET[Password] = '" + PWTextBox.Text + "', [AccessLevel] = '" + ALcb.Text + "' , [Department] = '" + DEPcb.Text + "' WHERE[UserName] = '" + UNcb.Text + "'";
                UNcb.Focus();
                _command = new SqlCommand(sqlQuery, _connection);
                _command.ExecuteNonQuery();
                _connection.Close();
                LoadData();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            _connection = DB_Connect.connect();

            _connection.Open();
                var sqlQuery = @"DELETE FROM[Users] WHERE[UserName] = '" + UNcb.Text + "'";
                _command = new SqlCommand(sqlQuery, _connection);
                _command.ExecuteNonQuery();
                _connection.Close();

            UNcb.Focus();
            LoadData();
        }

        private void DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            UNcb.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            DEPcb.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            ALcb.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            PWTextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillComboBox();
        }

        private void FillComboBox()
        {
            _connection = DB_Connect.connect();
            _command = new SqlCommand(@"SELECT * FROM[Users] WHERE[UserName] = '" + UNcb.Text + "'", _connection);
            try
            {
                _connection.Open();
                var myReader = _command.ExecuteReader();

                while (myReader.Read())
                {
                    DEPcb.SelectedIndex = DEPcb.FindString(myReader.GetString(1));
                    var x = myReader.GetInt32(4);
                    string y = x.ToString();
                    ALcb.SelectedIndex = ALcb.FindString(y);
                    PWTextBox.Text = myReader.GetString(3);
                }
                _connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillComboBox2()
        {
            _connection = DB_Connect.connect();
            _command = new SqlCommand(@"SELECT [UserName] FROM[Users]", _connection);
            try
            {
                _connection.Open();
                var myReader = _command.ExecuteReader();

                while (myReader.Read())
                {
                    UNcb.Items.Add(myReader.GetString(0));
                }
                _connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
