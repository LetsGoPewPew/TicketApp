using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class Customer
    {
        private static List<Customer> customerList = new List<Customer>();
        public static List<Customer> CustomerList { get => customerList; set => customerList = value; }

        private static int customers = 0;

        private int id;
        public int Id { get => id; set => id = value; }

        private string name;
        public string Name { get => name; set => name = value; }

        private string email;
        public string Email { get => email; set => email = value; }

        private string password;
        public string Password { get => password; set => password = value; }

        public Customer(string name, string email, string password)
        {
            this.Id = customers++;

            Name = name;
            Email = email;
            Password = password;

            Customer.CustomerList.Add(this);
        }

        public static bool Login(string email, string password)
        {
            foreach (Customer customer in Customer.CustomerList)
            {
                if (customer.Email == email && customer.Password == password)
                    return true;
            }
            return false;
        }

        public static bool EmailInUse(string email)
        {
            foreach (Customer customer in Customer.CustomerList)
            {
                if (customer.Email == email)
                    return true;
            }
            return false;
        }
    }
}