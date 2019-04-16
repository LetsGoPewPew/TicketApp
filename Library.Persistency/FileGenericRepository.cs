using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Persistency
{
    public class FileGenericRepository<T> : IRepository<T> where T : class
    {
        public IQueryable<T> Entities { get; set; }

        public void Add(T entity)
        {
            List<T> entities = Entities.ToList();
            entities.Add(entity);
            Entities = entities.AsQueryable();
        }

        public void Remove(T entity)
        {
            List<T> entities = Entities.ToList();
            entities.Remove(entity);
            Entities = entities.AsQueryable();
        }
    }
}