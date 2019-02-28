using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class Customer
    {
        private static List<Customer> userList = new List<Customer>();
        public static List<Customer> UserList { get => userList; set => userList = value; }

        private string name;
        public string Name { get => name; set => name = value; }

        private string email;
        public string Email { get => email; set => email = value; }

        private string password;
        public string Password { get => password; set => password = value; }
        
        public Customer(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;

            Customer.UserList.Add(this);
        }

        public static bool Login(string email, string password)
        {
            foreach(Customer customer in Customer.UserList)
            {
                if (customer.Email == email && customer.Password == password)
                    return true;
            }
            return false;
        }
    }
}