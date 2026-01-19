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
    public partial class UpdateCustomer : Form
    {
        public UpdateCustomer()
        {
            InitializeComponent();
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearchCustomer_Click(object sender, EventArgs e)
        {
            if (textSearchCustomer.Text == "")
            {
                MessageBox.Show("Fill in the search field");
            }
            else 
            { 
                labelCustomerId.Visible = true;
                textCustomerId.Visible = true;
                labelName.Visible = true;
                textName.Visible = true;
                labelSurname.Visible = true;
                textSurname.Visible = true;
                labelPhone.Visible = true;
                textPhone.Visible = true;
                labelEmail.Visible = true;
                textEmail.Visible = true;
                buttonUpdateCustomer.Visible = true;
            }
        }

        private void buttonUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (textName.Text == "" || textSurname.Text == "" || textPhone.Text == "" || textEmail.Text =="")
            {
                MessageBox.Show("Fill in all fields");
            }
            else
            {
                MessageBox.Show("Profile updated");
                this.Close();
            }
        }
    }
}
