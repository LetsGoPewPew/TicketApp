using Library.Model;

namespace Library.Logic
{
    public class UserLogic
    {
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