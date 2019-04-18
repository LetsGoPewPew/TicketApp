using System.Collections.Generic;
using System.Linq;

namespace Library.Persistency
{
    public class ListGenericRepository<T> : IRepository<T> where T : class
    {
        private List<T> entities = new List<T>();
        public IQueryable<T> Entities { get; set; }

        public ListGenericRepository()
        {
            Entities = entities.AsQueryable();
        }

        public void Add(T entity)
        {
            entities.Add(entity);
            Entities = entities.AsQueryable();
        }

        public void Remove(T entity)
        {
            entities.Remove(entity);
            Entities = entities.AsQueryable();
        }
    }
}