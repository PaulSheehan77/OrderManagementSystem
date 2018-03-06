using System;
using System.Windows.Forms;

namespace FYP___OrderManagementSystem
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar2.Increment(1);
            if (progressBar2.Value == 100)
                timer1.Stop();
        }
    }
}
