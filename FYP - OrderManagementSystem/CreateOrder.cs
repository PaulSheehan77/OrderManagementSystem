using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FYP___OrderManagementSystem
{
    public partial class CreateOrder : Form
    {
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
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
        }
    }
}
