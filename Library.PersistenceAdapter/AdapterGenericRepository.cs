using Library.Model;
using Library.Persistency;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.PersistenceAdapter
{
    public class AdapterGenericRepository : ITargetPersistenceAdapter
    {
        public UnitOfWork UnitOfWorkRepository { get; set; }

        public AdapterGenericRepository(UnitOfWork unitOfWorkRepository) 
        {
            UnitOfWorkRepository = unitOfWorkRepository;
        }

        public void Add<T>(IRepository<T> repository, T entity) where T : class
        {
            repository.Add(entity);
        }

        public void Remove<T>(IRepository<T> repository, T entity) where T : class
        {
            repository.Remove(entity);
        }
        public IEnumerable<T> GetAll<T>(IRepository<T> repository) where T : class
        {
            return repository.Entities.AsEnumerable();
        }

        public void Dispose()
        {
            UnitOfWorkRepository.Dispose();
        }

        public void Undo()
        {
            UnitOfWorkRepository.RejectChanges();
        }

        public void Save()
        {
            UnitOfWorkRepository.Commit();
        }
    }
}