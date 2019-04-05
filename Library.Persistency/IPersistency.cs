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
        void Persist(string data);
        void Persist(SocialEvent socialEvent);
        void Persist(Organizer organizer);
        void Persist(Customer customer);
        void Persist(Ticket ticket);
    }
}