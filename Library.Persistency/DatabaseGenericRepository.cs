using Library.DataAccess;
using System.Data.Entity;
using System.Linq;

namespace Library.Persistency
{
    public class DatabaseGenericRepository<T> : IRepository<T> where T : class
    {
        private readonly MyDbContext _dbContext;

        private IDbSet<T> _dbSet => _dbContext.Set<T>();
        public IQueryable<T> Entities => _dbSet;

        public DatabaseGenericRepository(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }
        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }
    }
}