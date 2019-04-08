using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Persistency
{
    public interface IUnitOfWork
    {
        IRepository<Customer> CustomerRepository { get; set; }
        IRepository<Organizer> OrganizerRepository { get; set; }
        IRepository<SocialEvent> SocialEventRepository { get; set; }

        void Commit();
        void RejectChanges();
        void Dispose();
    }
}