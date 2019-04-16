using Library.Persistency;
using System.Collections.Generic;
using System.Linq;

namespace Library.PersistenceAdapter
{
    public class AdapterGenericRepository : ITargetPersistenceAdapter
    {
        public IUnitOfWork UnitOfWorkRepository { get; set; }

        public AdapterGenericRepository(IUnitOfWork unitOfWorkRepository) 
        {
            UnitOfWorkRepository = unitOfWorkRepository;
        }

        public void Add<T>(IRepository<T> repository, T entity) where T : class
        {
            repository.Add(entity);
        }

        public void Add<T>(IRepository<T> repository, List<T> entities) where T : class
        {
            foreach(T entity in entities)
            {
                Add(repository, entity);
            }
        }

        public void Remove<T>(IRepository<T> repository, T entity) where T : class
        {
            repository.Remove(entity);
        }

        public void Remove<T>(IRepository<T> repository, List<T> entities) where T : class
        {
            foreach(T entity in entities)
            {
                repository.Remove(entity);
            }
        }


        public IEnumerable<T> GetAll<T>(IRepository<T> repository) where T : class
        {
            return repository.Entities.AsEnumerable();
        }

        public IUnitOfWork GetUnitOfWork()
        {
            return UnitOfWorkRepository;
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