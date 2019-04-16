using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model;

namespace Library.Persistency
{
    public class FileUnitOfWork : IUnitOfWork
    {
        public IRepository<Customer> CustomerRepository => throw new NotImplementedException();

        public IRepository<Organizer> OrganizerRepository => throw new NotImplementedException();

        public IRepository<SocialEvent> SocialEventRepository => throw new NotImplementedException();

        public IRepository<Ticket> TicketRepository => throw new NotImplementedException();

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void RejectChanges()
        {
            throw new NotImplementedException();
        }
    }
}