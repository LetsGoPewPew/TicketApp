using Library.Persistency;
using System.Collections.Generic;

namespace Library.PersistenceAdapter
{
    public interface ITargetPersistenceAdapter
    {
        void Add<T>(IRepository<T> repository, T entity) where T : class;
        void Add<T>(IRepository<T> repository, List<T> entity) where T : class;
        void Remove<T>(IRepository<T> repository, T entity) where T : class;
        void Remove<T>(IRepository<T> repository, List<T> entity) where T : class;
        IEnumerable<T> GetAll<T>(IRepository<T> repository) where T : class;

        IUnitOfWork GetUnitOfWork();
        void Dispose();
        void Undo();
        void Save();
    }
}