using Library.Persistency;
using System;

namespace Library.PersistenceAdapter
{
    public class AdapterGenericRepository<T> : ITargetPersistenceAdapter where T : class
    {
        public UnitOfWork UnitOfWorkRepository { get; set; }

        public AdapterGenericRepository(UnitOfWork unitOfWorkRepository) 
        {
            UnitOfWorkRepository = unitOfWorkRepository;
        }

        public void Add(T entity)
        {
        }

        public void Remove(T a)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            UnitOfWorkRepository.Dispose();
        }

        public void Save()
        {
            UnitOfWorkRepository.Commit();
        }

        public void Undo()
        {
            UnitOfWorkRepository.RejectChanges();
        }
    }
}