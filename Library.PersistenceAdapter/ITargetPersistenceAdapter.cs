using Library.Persistency;
using System.Collections.Generic;
using System.Linq;

namespace Library.PersistenceAdapter
{
    public interface ITargetPersistenceAdapter
    {
        void Add<T>(IRepository<T> repository, T entity) where T : class;
        void Remove<T>(IRepository<T> repository, T entity) where T : class;
        IEnumerable<T> GetAll<T>(IRepository<T> repository) where T : class;

        void Dispose();
        void Undo();
        void Save();
    }
}