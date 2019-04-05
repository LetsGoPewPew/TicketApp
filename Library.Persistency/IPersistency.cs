using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Persistency
{
    public interface IPersistency
    {
        void Store(string data);
        void Store(SocialEvent socialEvent);
        void Store(Organizer organizer);
        void Store(Customer customer);
        void Store(Ticket ticket);
    }
}