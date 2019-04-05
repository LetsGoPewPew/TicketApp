using Library.Model;

namespace Library.Persistency
{
    public class PersistentProcess
    {
        public PersistentEventHandler<Customer> Customers = new PersistentEventHandler<Customer>();
        public PersistentEventHandler<Organizer> Organizers = new PersistentEventHandler<Organizer>();
        public PersistentEventHandler<SocialEvent> SocialEvents = new PersistentEventHandler<SocialEvent>();
        public PersistentEventHandler<Ticket> Tickets = new PersistentEventHandler<Ticket>();
    }
}