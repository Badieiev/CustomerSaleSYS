using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerSaleSYS
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            if (textName.Text == "" || textSurname.Text == "" || textPhone.Text == "" || textEmail.Text == "")
            {
                MessageBox.Show("Fill in all fields");
            }
            else if (!Validation.IsAlphabetical(textName.Text))
            {
                MessageBox.Show("Only letters can be used in the name field.");
            }
            else if (!Validation.IsAlphabetical(textSurname.Text))
            {
                MessageBox.Show("Only letters can be used in the surname field.");
            }
            else if (!Validation.IsValidPhone(textPhone.Text))
            {
                MessageBox.Show("The phone number must contain 10 digits and only digits");
            }
            else if (!Validation.IsValidEmail(textEmail.Text))
            {
                MessageBox.Show("Incorrect email format");
            }
            else 
            {
                MessageBox.Show("Customer added");
                this.Close();
            }
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
