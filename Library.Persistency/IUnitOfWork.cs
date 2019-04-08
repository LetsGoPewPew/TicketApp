using Library.Model;

namespace Library.Persistency
{
    public interface IUnitOfWork
    {
        IRepository<Customer> CustomerRepository { get; }
        IRepository<Organizer> OrganizerRepository { get; }
        IRepository<SocialEvent> SocialEventRepository { get; }

        void Commit();
        void RejectChanges();
        void Dispose();
    }
}