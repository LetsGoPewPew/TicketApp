using Library.Model;
using Library.PersistenceAdapter;

namespace Library.Logic
{
    public class UserLogic
    {
        public static bool Login(string email, string password)
        {
            foreach (User user in User.UserList)
            {
                if (user.Email == email && user.Password == password)
                    return true;
            }
            return false;
        }

        public static bool EmailInUse(string email)
        {
            foreach (User user in User.UserList)
            {
                if (user.Email == email)
                    return true;
            }
            return false;
        }

        public static bool Authorize(string email, string password)
        {
            foreach(User user in User.UserList)
            {
                if (user.Email == email && user.Password == password)
                    return true;
            }
            return false;
        }

        public static User GetUserByEmail(string email)
        {
            foreach (User user in User.UserList)
            {
                if (user.Email == email)
                    return user;
            }
            return null;
        }

        public static Organizer UpgradeCustomer(Customer customer)
        {
            Organizer newOrganizer = new Organizer((Customer)customer);
            User.UserList.Remove(customer);
            Customer.CustomerList.Remove((Customer)customer);
            return newOrganizer;
        }
    }
}