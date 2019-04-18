using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model;

namespace Library.Persistency
{
    public class ListUnitOfWork : IUnitOfWork
    {
        public IRepository<Customer> CustomerRepository =>
            new ListGenericRepository<Customer>();

        public IRepository<Organizer> OrganizerRepository =>
            new ListGenericRepository<Organizer>();

        public IRepository<SocialEvent> SocialEventRepository =>
            new ListGenericRepository<SocialEvent>();

        public IRepository<Ticket> TicketRepository =>
            new ListGenericRepository<Ticket>();

        public void Commit()
        {
            // Would save to file
        }

        public void Dispose()
        {
            // Disposes
        }

        public void RejectChanges()
        {
            // Would reject changes made
        }
    }
}
