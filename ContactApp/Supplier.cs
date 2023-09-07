using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp
{
    internal class Supplier : Contact
    {
        public string CodeScn;

        public Supplier(string name, string email, string phone, string codeScn) : base(name, email, phone)
        {
            CodeScn= codeScn;
        }

        public override string ToString()
        {
            return $"{Name} Email: {Email} Phone: {Phone} Code: {CodeScn}";
        }

        public void MakeOrder()
        {
            Console.WriteLine("Order made");
        }
    }
}
