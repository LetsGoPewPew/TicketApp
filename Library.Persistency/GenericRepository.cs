using Library.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Persistency
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly MyDbContext _dbContext;
        private IDbSet<T> _dbSet => _dbContext.Set<T>();
        IQueryable IRepository<T>.Entities => _dbSet;

        public GenericRepository(MyDbContext dbContext)
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