using Library.Model;

namespace Library.Persistency
{
    public class TestPersistent
    {
        public Persistent<Customer> Customers { get; set; }
        public Persistent<Organizer> Organizers { get; set; }
        public Persistent<SocialEvent> SocialEvents{ get; set; }
        public Persistent<Ticket> Tickets{ get; set; }
        public TestPersistent()
        {
            Customers = new Persistent<Customer>();
            Organizers = new Persistent<Organizer>();
            SocialEvents = new Persistent<SocialEvent>();
            Tickets = new Persistent<Ticket>();
        }
    }
}