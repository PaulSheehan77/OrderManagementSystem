using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FYP___OrderManagementSystem
{
    public partial class LogGRN : Form
    {
        private SqlConnection _connection;
        private SqlCommand _command;
        private SqlDataAdapter _sda;
        private DataTable _dt;
        private float newQuantity;

        public LogGRN()
        {
            InitializeComponent();
            FillComboBox();
            FillDataGridView();
        }

        private void FillDataGridView()
        {
            _connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            _sda = new SqlDataAdapter(@"SELECT * FROM[OrderedItems] order by len(OrderID), OrderID", _connection);
            _dt = new DataTable();
            _sda.Fill(_dt);
            dataGridView2.Rows.Clear();

            foreach (DataRow item in _dt.Rows)
            {
                var n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = item["OrderID"].ToString();
                dataGridView2.Rows[n].Cells[1].Value = item["ProductCode"].ToString();
                dataGridView2.Rows[n].Cells[2].Value = item["Quantity"].ToString();
            }
        }

        private void FillComboBox()
        {
            _connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            _command = new SqlCommand(@"SELECT DISTINCT [OrderID] FROM[OrderedItems]", _connection);
            try
            {
                _connection.Open();
                var myReader = _command.ExecuteReader();

                while (myReader.Read())
                {
                    var oID = myReader.GetString(0);
                    OIDComboBox.Items.Add(oID);
                }
                _connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PCComboBox.Items.Clear();
            _connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            _command = new SqlCommand(@"SELECT * FROM[OrderedItems] WHERE [OrderID] = '" + OIDComboBox.Text + "'", _connection);
            try
            {
                _connection.Open();
                var myReader = _command.ExecuteReader();

                while (myReader.Read())
                {
                    var pCode = myReader.GetString(1);
                    newQuantity = myReader.GetFloat(2);
                    PCComboBox.Items.Add(pCode);
                }
                _connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void LogItemButton_Click(object sender, EventArgs e)
        {
            newQuantity = newQuantity - (Convert.ToSingle(QuantityUpDown.Text));
            _connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            _connection.Open();
            var sqlQuery = @"UPDATE [OrderedItems] SET [Quantity] = newQuantity WHERE[ProductCode] = '" + PCComboBox.Text + "' AND [OrderID] = '" + OIDComboBox + "'";
            _command = new SqlCommand(sqlQuery, _connection);
            _command.ExecuteNonQuery();
            _connection.Close();
            FillDataGridView();
        }

        private void PCComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _connection = new SqlConnection("Data Source=LAPTOP;Initial Catalog=FYP_DB;Integrated Security=True");
            _command = new SqlCommand(@"SELECT [Quantity] FROM[OrderedItems] WHERE [OrderID] = '" + OIDComboBox.Text + "' AND [ProductCode] = '" + PCComboBox.Text + "'", _connection);
            try
            {
                _connection.Open();
                var myReader = _command.ExecuteReader();

                while (myReader.Read())
                {
                    //QuantityUpDown.Maximum = new decimal(myReader.GetFloat(0));
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
