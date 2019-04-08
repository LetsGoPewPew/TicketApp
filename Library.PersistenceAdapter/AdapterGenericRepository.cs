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

        public void Delete(T entity)
        {
            GenericDatabaseRepository.Remove(entity);
        }

        public void Remove(T a)
        {
            throw new NotImplementedException();
        }

        public void Save(T a )
        {
            throw new NotImplementedException();
        }

        public void Undo(T a)
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}