using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactApp
{
    internal partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        public Contact GetContact()
        {
            string name = nameTextBox.Text;
            string email = emailTextBox.Text;
            string phone = phoneTextBox.Text;

            return new Contact(name, email, phone);
        }

        public Supplier GetSupplier()
        {
            string name = nameTextBox.Text;
            string email = emailTextBox.Text;
            string phone = phoneTextBox.Text;
            string codeScn = codeScnTextBox.Text;
            return new Supplier(name, email, phone, codeScn);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && emailTextBox.Text != "" && phoneTextBox.Text != "" && 
                codeScnTextBox.Text=="")
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else if (nameTextBox.Text != "" && emailTextBox.Text != "" && phoneTextBox.Text != "" &&
                     codeScnTextBox.Text != "")
            {
                DialogResult = DialogResult.Yes;
                Close();
            }
            else
            {
                MessageBox.Show("Please fill in required fields.");
            }
        }
    }
}
