using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactApp
{
    public partial class MainForm : Form
    {
        private ContactRegistry _registry;
        private DatabaseManager _databaseManager;

        public MainForm()
        {
            InitializeComponent();

            _registry = new ContactRegistry();
            _databaseManager = new DatabaseManager("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ContactManager;Integrated Security=True");

            LoadContacts();
        }

        private void LoadContacts()
        {
            List<Contact> contacts = _databaseManager.GetAllContacts();

            foreach (Contact contact in contacts)
            {
                contactsListBox.Items.Add(contact);
            }
        }

        private void addContactButton_Click(object sender, EventArgs e)
        {
            ContactForm contactForm = new ContactForm();

            if (contactForm.ShowDialog() == DialogResult.OK)
            {
                Contact contact = contactForm.GetContact();

                _registry.AddContact(contact);
                _databaseManager.SaveContacts(_registry.GetAllContacts());

                contactsListBox.Items.Add(contact);
            }
            else
            {
                Supplier supplier = contactForm.GetSupplier();
                if (supplier.CodeScn == "")
                {
                    return;
                }
                Contact contact = contactForm.GetContact();
                _registry.AddContact(contact);
                _registry.AddSupplier(supplier);
                _databaseManager.SaveContacts(_registry.GetAllContacts());
                _databaseManager.SaveSuppliers(_registry.GetAllSuppliers());

                contactsListBox.Items.Add(supplier);
            }
        }

        private void removeContactButton_Click(object sender, EventArgs e)
        {
            if (contactsListBox.SelectedItem != null)
            {
                object selected = contactsListBox.SelectedItem;
                Contact contact = (Contact)selected;
                _registry.RemoveContact(contact);
                _databaseManager.DeleteContact(contact);
                if (selected is Supplier)
                {
                    Supplier supplier = (Supplier)selected; 
                    _registry.RemoveSupplier(supplier);
                    _databaseManager.DeleteSupplier(supplier);
                    contactsListBox.Items.Remove(supplier);
                }
                else
                {
                    contactsListBox.Items.Remove(contact);
                }
            }
        }

        private void searchContactsByNameButton_Click(object sender, EventArgs e)
        {
            using (var searchForm = new SearchContactForm())
            {
                if (searchForm.ShowDialog() == DialogResult.OK)
                {
                  
                }
            }
        }

    }
}
