using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model;

namespace Library.Persistency
{
    class FakeListPersist : IPersistMethod
    {
        public void Persist(string data)
        {
            throw new NotImplementedException();
        }

        public void Persist(SocialEvent socialEvent)
        {
            throw new NotImplementedException();
        }

        public void Persist(Organizer organizer)
        {
            throw new NotImplementedException();
        }

        public void Persist(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Persist(Ticket ticket)
        {
            throw new NotImplementedException();
        }
    }
}
