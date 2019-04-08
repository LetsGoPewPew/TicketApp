using System.Collections.Generic;

namespace Library.Model
{
    public class Organizer : User
    {
        private static int NumberOfOrganizersCreated = 0;

        private static List<Organizer> organizerList = new List<Organizer>();
        public static List<Organizer> OrganizerList { get => organizerList; set => organizerList = value; }

        public Organizer() : base()
        {
            NumberOfOrganizersCreated++;

            Organizer.OrganizerList.Add(this);
        }

        public Organizer(string name, string email, string password) : base(name, email, password)
        {
            NumberOfOrganizersCreated++;

            Organizer.OrganizerList.Add(this);
        }

        public Organizer(Customer customer) : base(customer.Name, customer.Email, customer.Password)
        {
            NumberOfOrganizersCreated++;

            Organizer.OrganizerList.Add(this);
        }
    }
}