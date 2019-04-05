using Library.Model;

namespace Library.Persistency
{
    public static class TestPersistency
    {
        public static Persistent<Customer> Customers = new Persistent<Customer>();
        public static Persistent<Organizer> Organizers = new Persistent<Organizer>();
        public static Persistent<SocialEvent> SocialEvents = new Persistent<SocialEvent>();
        public static Persistent<Ticket> Tickets = new Persistent<Ticket>();
    }
}