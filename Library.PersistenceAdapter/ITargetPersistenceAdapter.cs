using Library.Persistency;

namespace Library.PersistenceAdapter
{
    public interface ITargetPersistenceAdapter<T> where T : class
    {
        void Add(IRepository<T> repository, T entity);
        void Remove(IRepository<T> repository, T entity);

        void Dispose();
        void Undo();
        void Save();
    }
}