using Library.Model;
using Library.Persistency;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.PersistenceAdapter
{
    public class AdapterGenericRepository<T> : ITargetPersistenceAdapter<T> where T : class
    {
        public UnitOfWork UnitOfWorkRepository { get; set; }

        public AdapterGenericRepository(UnitOfWork unitOfWorkRepository) 
        {
            UnitOfWorkRepository = unitOfWorkRepository;
        }

        public void GetT(IRepository<T> repo, T entity)
        {
            repo.Add(entity);
        }

        public void Add(IRepository<T> repository, T entity)
        {
            repository.Add(entity);
        }

        public void Remove(IRepository<T> repository, T entity)
        {
            repository.Remove(entity);
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