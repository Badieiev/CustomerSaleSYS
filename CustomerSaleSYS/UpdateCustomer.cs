using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CustomerSaleSYS
{
    public partial class UpdateCustomer : Form
    {
        private Customer customer;
        public UpdateCustomer()
        {
            InitializeComponent();
        }

        private void ButtonSearchCustomer_Click(object sender, EventArgs e)
        {
            grdCustomers.DataSource = Customer.FindAllCustomers(textSearchCustomer.Text).Tables[0];

            if (grdCustomers.Rows.Count == 0)
            {
                MessageBox.Show("No Data Found");
                textSearchCustomer.Focus();
                return;
            }
            grdCustomers.Visible = true;
            textId.Enabled = false;
        }

        private void GrdCustomersCellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(grdCustomers.Rows[grdCustomers.CurrentCell.RowIndex].Cells[0].Value);
            customer = Customer.GetCustomer(id);
            textId.Text = customer.Id.ToString();
            textName.Text = customer.FirstName;
            textSurname.Text = customer.LastName;
            textPhone.Text = customer.Phone;
            textEmail.Text = customer.Email;
            cboStatus.Items.Clear();
            cboStatus.Items.Add(customer.Status);
            cboStatus.Items.Add(Customer.AddCboItem(customer.Status));
            cboStatus.SelectedIndex = 0;
            if (customer.Status == 'A')
            {
                cboStatus.Visible = false;
                labelStatus.Visible = false;
                textName.Enabled = true;
                textSurname.Enabled = true;
                textPhone.Enabled = true;
                textEmail.Enabled = true;
            }
            else
            {
                cboStatus.Visible = true;
                labelStatus.Visible = true;
                textName.Enabled = false;
                textSurname.Enabled = false;
                textPhone.Enabled = false;
                textEmail.Enabled = false;
            }
            grpCustomer.Visible = true;
        }

        private void ButtonUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (textName.Text == "" || textSurname.Text == "" || textPhone.Text == "" || textEmail.Text == "" || cboStatus.Text == "")
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
            else if (!Customer.IsUniqEmailForUpdate(Convert.ToInt32(textId.Text), textEmail.Text))
            {
                MessageBox.Show("Update not possible. A user with this email address already exists in the database.");
            }
            else
            {
                customer.FirstName = textName.Text;
                customer.LastName = textSurname.Text;
                customer.Phone = textPhone.Text;
                customer.Email = textEmail.Text;
                customer.Status = cboStatus.Text[0];
                customer.UpdateCustomer();
                MessageBox.Show("Profile updated");
                this.Close();
            }
        }

        private void ButtonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
