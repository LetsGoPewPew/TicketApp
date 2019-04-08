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

        public void Add(T entity)
        {
            switch (entity)
            {
                default:
                case Customer customer:
                    UnitOfWorkRepository.CustomerRepository.Add(entity as Customer);
                    break;
                case Organizer organizer:
                    UnitOfWorkRepository.OrganizerRepository.Add(entity as Organizer);
                    break;
                case SocialEvent socialEvent:
                    UnitOfWorkRepository.SocialEventRepository.Add(entity as SocialEvent);
                    break;
                case Ticket ticket:
                    UnitOfWorkRepository.TicketRepository.Add(entity as Ticket);
                    break;
            }
        }

        public void Remove(T entity)
        {
            switch (entity)
            {
                default:
                case Customer customer:
                    UnitOfWorkRepository.CustomerRepository.Remove(entity as Customer);
                    break;
                case Organizer organizer:
                    UnitOfWorkRepository.OrganizerRepository.Remove(entity as Organizer);
                    break;
                case SocialEvent socialEvent:
                    UnitOfWorkRepository.SocialEventRepository.Remove(entity as SocialEvent);
                    break;
                case Ticket ticket:
                    UnitOfWorkRepository.TicketRepository.Remove(entity as Ticket);
                    break;
            }
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