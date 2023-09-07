using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp
{
    internal class ContactRegistry
    {
        private List<Contact> _contacts;
        private List<Supplier> _suppliers;

        public ContactRegistry()
        {
            _contacts = new List<Contact>();
            _suppliers = new List<Supplier>();
        }

        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }

        public void AddSupplier(Supplier supplier)
        {
            _suppliers.Add(supplier);
        }

        public void RemoveContact(Contact contact)
        {
            _contacts.Remove(contact);
        }

        public void RemoveSupplier(Supplier supplier)
        {
            _suppliers.Remove(supplier);
        }

        public List<Contact> GetAllContacts()
        {
            return _contacts;
        }

        public List<Supplier> GetAllSuppliers()
        {
            return _suppliers;
        }
    }
}
