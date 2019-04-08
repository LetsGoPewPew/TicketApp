namespace Library.PersistenceAdapter
{
    public interface ITargetPersistenceAdapter
    {
        void Add();
        void Remove();

        void Delete();
        void Undo();
        void Save();
    }
}