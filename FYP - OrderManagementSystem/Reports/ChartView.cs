using System;
using System.Windows.Forms;

namespace FYP___OrderManagementSystem.Reports
{
    public partial class ChartView : Form
    {

        private string error = "You have at least one option left to pick before you can generate a chart.\n\nPlease select both chart data and chart type and try again.";
        private readonly string _dep = Constants.dep;
        private readonly string _emp = Constants.emp;
        private readonly string _bar = Constants.bar;
        private readonly string _line = Constants.line;

        public ChartView()
        {
            InitializeComponent();
            comboBox1.Items.Add(_dep);
            comboBox1.Items.Add(_emp);
            comboBox2.Items.Add(_bar);
            comboBox2.Items.Add(_line);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            
            if (comboBox1.Text == _dep)
            {
                DepOrdersBarChart dobc = new DepOrdersBarChart { TopLevel = false, AutoScroll = true };
                DepOrdersLineChart dolc = new DepOrdersLineChart { TopLevel = false, AutoScroll = true };

                if (comboBox2.Text == _bar)
                {
                    panel2.Controls.Add(dobc);
                    dobc.Show(); 
                }
                else if (comboBox2.Text == _line)
                {
                    panel2.Controls.Add(dolc);
                    dolc.Show();
                }
                else
                {
                    MessageBox.Show(error);
                }

            }
            else if (comboBox1.Text == _emp)
            {
                EmpOrdersBarChart eobc = new EmpOrdersBarChart { TopLevel = false, AutoScroll = true };
                EmpOrdersLineChart eolc = new EmpOrdersLineChart { TopLevel = false, AutoScroll = true };

                if (comboBox2.Text == _bar)
                {
                    panel2.Controls.Add(eobc);
                    eobc.Show();
                }
                else if (comboBox2.Text == _line)
                {
                    panel2.Controls.Add(eolc);
                    eolc.Show();
                }
                else
                {
                    MessageBox.Show(error);
                }
                
            }
            else
            {
                MessageBox.Show(error);
            }
        }
    }
}
