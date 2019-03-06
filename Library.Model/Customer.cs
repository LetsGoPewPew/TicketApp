using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class Customer : User
    {
        private static int NumberOfCustomersCreated = 0;

        private static List<Customer> customerList = new List<Customer>();
        public static List<Customer> CustomerList { get => customerList; set => customerList = value; }

        public Customer(string name, string email, string password) : base(name, email, password)
        {
            NumberOfCustomersCreated++;

            Customer.CustomerList.Add(this);
        }
    }
}