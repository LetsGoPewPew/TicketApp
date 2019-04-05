using Library.Model;

namespace Library.Persistency
{
    public class PersistentProcess<T> where T:IPersistMethod
    {
        public PersistentEventHandler<Customer, IPersistMethod> Customers;
        public PersistentEventHandler<Organizer, IPersistMethod> Organizers;
        public PersistentEventHandler<SocialEvent, IPersistMethod> SocialEvents;
        public PersistentEventHandler<Ticket, IPersistMethod> Tickets;

        public PersistentProcess(T persistMethod) 
        {
            Customers = new PersistentEventHandler<Customer, IPersistMethod>(persistMethod);
            Organizers = new PersistentEventHandler<Organizer, IPersistMethod>(persistMethod);
            SocialEvents = new PersistentEventHandler<SocialEvent, IPersistMethod>(persistMethod);
            Tickets= new PersistentEventHandler<Ticket, IPersistMethod>(persistMethod);
        }
    }
}