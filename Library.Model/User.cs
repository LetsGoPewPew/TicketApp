using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.Model
{
    public abstract class User
    {
        private static List<User> userList = new List<User>();
        public static List<User> UserList { get => userList; set => userList = value; }

        private List<Ticket> ownedTickets;
        public  List<Ticket> OwnedTickets { get => ownedTickets; set => ownedTickets = value; }

        private static int NumbersOfUsersCreated = 0;

        private int id;
        public int Id { get => id; private set => id = value; }

        private string name;
        public string Name { get => name; set => name = value; }

        private string email;
        public string Email { get => email; set => email = value; }

        private string password;
        public string Password { get => password; set => password = value; }

        public User()
        {
            this.Id = NumbersOfUsersCreated++;

            User.UserList.Add(this);
        }

        protected User(string name, string email, string password)
        {
            this.Id = NumbersOfUsersCreated++;

            UserList = userList;
            Name = name;
            Email = email;
            Password = password;

            User.UserList.Add(this);
        }
    }
}
