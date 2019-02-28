using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class Organizer : User
    {
        private static List<Organizer> organizerList = new List<Organizer>();
        public static List<Organizer> OrganizerList { get => organizerList; set => organizerList = value; }

        private static int NumberOfOrganizersCreated = 0;

        public Organizer(string name, string email, string password) : base(name, email, password)
        {
            NumberOfOrganizersCreated++;

            Organizer.OrganizerList.Add(this);
        }
    }
}