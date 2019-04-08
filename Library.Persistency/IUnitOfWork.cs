using Library.Model;

namespace Library.Persistency
{
    public interface IUnitOfWork
    {
        IRepository<Customer> CustomerRepository { get; }
        IRepository<Organizer> OrganizerRepository { get; }
        IRepository<SocialEvent> SocialEventRepository { get; }
        IRepository<Ticket> TicketRepository { get; }

        void Commit();
        void RejectChanges();
        void Dispose();
    }
}