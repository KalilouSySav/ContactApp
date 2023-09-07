using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactApp
{
    internal partial class SearchContactForm : Form
    {
        private DatabaseManager _databaseManager = new DatabaseManager(
                "Data Source=(localdb)\\MSSQLLocalDB;" +
                "Initial Catalog=ContactManager;" +
                "Integrated Security=True");

        public SearchContactForm()
        {
            InitializeComponents();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchName = nameTextBox.Text;


            List<Supplier> searchSuppliersResults = PerformSuppliersSearch(searchName);
            if (searchSuppliersResults.Count==0)
            {
                List<Contact> searchContactsResults = PerformContactsSearch(searchName);
                // Affichez les résultats dans la ListBox
                resultsListBox.Items.Clear();
                resultsListBox.Items.AddRange(searchContactsResults.ToArray());
            }
            else
            {
                // Affichez les résultats dans la ListBox
                resultsListBox.Items.Clear();
                resultsListBox.Items.AddRange(searchSuppliersResults.ToArray());
            }


        }

        private List<Contact> PerformContactsSearch(string SearchName)
        {
            List<Contact>  SearchNameContacts= new List<Contact>();
            // Effectuez la recherche par nom
            SearchNameContacts = _databaseManager.GetContactsByName(SearchName);
            // Retournez une liste de contacts correspondant à la recherche

            return SearchNameContacts;
        }

        private List<Supplier> PerformSuppliersSearch(string SearchName)
        {
            List<Supplier> SearchNameSuppliers = new List<Supplier>();
            // Effectuez la recherche par nom
            SearchNameSuppliers = _databaseManager.GetSuppliersByName(SearchName);
            // Retournez une liste de fournisseurs correspondant à la recherche
            return SearchNameSuppliers;
        }

    }
}
