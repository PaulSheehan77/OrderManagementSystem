using System.Windows.Forms;

namespace FYP___OrderManagementSystem
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            label1.Text = "Welcome " + Login.Forename + "!";
        }
    }
}
