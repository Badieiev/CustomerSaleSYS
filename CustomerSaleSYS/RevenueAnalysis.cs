using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerSaleSYS
{
    public partial class RevenueAnalysis : Form
    {
        public RevenueAnalysis()
        {
            InitializeComponent();
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonShowGraph_Click(object sender, EventArgs e)
        {
            if (comboBoxYear.Text == "2024")
            {
                pictureBoxRevenue.Visible = true;
                pictureBoxRevenue.Image = Properties.Resources.revenue2024;
            }
            else if(comboBoxYear.Text == "2025")
            {
                pictureBoxRevenue.Visible = true;
                pictureBoxRevenue.Image= Properties.Resources.revenue2025;
            }
            else
            {
                MessageBox.Show("Please select a year");
            }
        }
    }
}
