using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp
{
    internal class DatabaseManager
    {
        private string _connectionString;

        public DatabaseManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void SaveContacts(List<Contact> contacts)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO Contacts (Name, Email, Phone) " +
                                                    "VALUES (@Name, @Email, @Phone)", connection);

                foreach (Contact contact in contacts)
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@Name", contact.Name);
                    command.Parameters.AddWithValue("@Email", contact.Email);
                    command.Parameters.AddWithValue("@Phone", contact.Phone);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void SaveSuppliers(List<Supplier> suppliers)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Suppliers (Name, Email, Phone, CodeScn) " +
                                                    "VALUES (@Name, @Email, @Phone, @CodeScn)", connection);
                foreach (Supplier supplier in suppliers)
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@Name", supplier.Name);
                    command.Parameters.AddWithValue("@Email", supplier.Email);
                    command.Parameters.AddWithValue("@Phone", supplier.Phone);
                    command.Parameters.AddWithValue("@CodeScn", supplier.CodeScn);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Contact> GetAllContacts()
        {
            List<Contact> contacts = new List<Contact>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Contacts", connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader.GetString(1);
                    string email = reader.GetString(2);
                    string phone = reader.GetString(3);

                    Contact contact = new Contact(name, email, phone);
                    contacts.Add(contact);
                }
            }

            return contacts;
        }

        public List<Supplier> GetAllSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Suppliers", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader.GetString(1);
                    string email = reader.GetString(2);
                    string phone = reader.GetString(3);
                    string codeScn = reader.GetString(4);
                    Supplier supplier = new Supplier(name, email, phone, codeScn);
                    suppliers.Add(supplier);
                }
            }

            return suppliers;
        }

        public List<Contact> GetContactsByName(string name)
        {
            List<Contact> contacts = new List<Contact>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Contacts WHERE Name LIKE @Name", connection);
                command.Parameters.AddWithValue("@Name", $"%{name}%");
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string contactName = reader.GetString(1);
                    string email = reader.GetString(2);
                    string phone = reader.GetString(3);
                    Contact contact = new Contact(contactName, email, phone);
                    contacts.Add(contact);
                }
            }

            return contacts;
        }

        public List<Supplier> GetSuppliersByName(string name)
        {
            List<Supplier> suppliers = new List<Supplier>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Suppliers WHERE Name LIKE @Name", connection);
                command.Parameters.AddWithValue("@Name", $"%{name}%");
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string supplierName = reader.GetString(1);
                    string email = reader.GetString(2);
                    string phone = reader.GetString(3);
                    string codeScn = reader.GetString(4);
                    Supplier supplier = new Supplier(supplierName, email, phone, codeScn);
                    suppliers.Add(supplier);
                }
            }
            return suppliers;
        }

        public void DeleteContact(Contact contact)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Contacts WHERE Name = @Name", connection);
                command.Parameters.AddWithValue("@Name", contact.Name);
                command.ExecuteNonQuery();
               
            }
        }

        public void DeleteSupplier(Supplier supplier)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Suppliers WHERE Name = @Name " +
                                                    "AND CodeScn = @Code", connection);
                command.Parameters.AddWithValue("@Name", supplier.Name);
                command.Parameters.AddWithValue("@Code", supplier.CodeScn);
                command.ExecuteNonQuery();
            }
        }
    }
}
