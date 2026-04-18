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

        private void FormAddCustomerLoad(object sender, EventArgs e)
        {
            textID.Text = Customer.GetNextCustomerID().ToString("0000");
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
            else if (!Validation.IsValidPhoneNumber(textPhone.Text))
            {
                MessageBox.Show("The phone number must start with +353 or 0 and then be 9 digits long.");
            }
            else if (!Validation.IsValidEmail(textEmail.Text))
            {
                MessageBox.Show("Incorrect email format");
            }
            else
            {
                if (!Customer.IsUniqEmail(textEmail.Text))
                {
                    MessageBox.Show("This Email already exists in the system!");
                    return;
                }

                Customer aCustomer = new Customer(Convert.ToInt32(textID.Text), textName.Text, textSurname.Text, textPhone.Text, textEmail.Text);
                aCustomer.AddCustomer();
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
