namespace Library.PersistenceAdapter
{
    public interface ITargetPersistenceAdapter<T> where T : class
    {
        void Add(T entity);
        void Remove(T entity);

        void Delete();
        void Undo();
        void Save();
    }
}