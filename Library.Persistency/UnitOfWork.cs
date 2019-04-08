using Library.DataAccess;
using Library.Model;
using System.Data.Entity;
using System.Linq;

namespace Library.Persistency
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyDbContext _dbContext;

        public IRepository<Customer> CustomerRepository =>
            new GenericRepository<Customer>(_dbContext);
        public IRepository<Organizer> OrganizerRepository =>
            new GenericRepository<Organizer>(_dbContext);
        public IRepository<SocialEvent> SocialEventRepository =>
            new GenericRepository<SocialEvent>(_dbContext);
        public IRepository<Ticket> TicketRepository =>
            new GenericRepository<Ticket>(_dbContext);

        public UnitOfWork(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public void RejectChanges()
        {
            foreach (var entry in _dbContext.ChangeTracker.Entries()
                  .Where(e => e.State != EntityState.Unchanged))
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Modified:
                    case EntityState.Deleted:
                        entry.Reload();
                        break;
                }
            }
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
