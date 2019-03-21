using Library.Model;

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
            foreach (Customer customer in Customer.CustomerList)
            {
                if (customer.Email == email)
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
    }
}