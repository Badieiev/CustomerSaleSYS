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
        private Customer customer;
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
            grdCustomers.DataSource = Customer.FindCustomers(textSearchCustomer.Text).Tables[0];

            if (grdCustomers.Rows.Count == 0)
            {
                MessageBox.Show("No Data Found");
                textSearchCustomer.Focus();
                return;
            }

            grdCustomers.Visible = true;

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

        private void grdCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id = Convert.ToInt32(grdCustomers.Rows[grdCustomers.CurrentCell.RowIndex].Cells[0].Value);

            customer = Customer.GetCustomer(Id);
            textName.Text = customer.FirstName;
            textSurname.Text = customer.LastName;
            textPhone.Text = customer.Phone;
            textEmail.Text = customer.Email;

            grpCustomer.Visible = true;
        }
    }
}
