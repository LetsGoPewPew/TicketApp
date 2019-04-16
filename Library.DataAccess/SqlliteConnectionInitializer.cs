using Library.Model;
using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess
{
    public class SqlliteConnectionInitializer : SqliteDropCreateDatabaseWhenModelChanges<MyDbContext>
    {
        public SqlliteConnectionInitializer(DbModelBuilder modelBuilder) : base(modelBuilder) { }

        protected override void Seed(MyDbContext context)
        {
            Customer customer1 = new Customer("1", "1", "1");
            Customer customer2 = new Customer("2", "2", "2");

            context.Customers.Add(customer1);
            context.Customers.Add(customer2);

            Organizer organizer1 = new Organizer("3", "3", "3");

            context.Organizers.Add(organizer1);

            SocialEvent socialEvent1 = new SocialEvent(5, 133, "Art", "Kristine og Ramona synger bæ bæ lille lam");
            SocialEvent socialEvent2 = new SocialEvent(7, 5643, "Sports", "Stian og Jørgen Sjonglerer med datamus");
            SocialEvent socialEvent3 = new SocialEvent(9, 2312, "TalentShow", "Juan kjører solo dukkeshow");
            SocialEvent socialEvent4 = new SocialEvent(5, 436, "Sports", "Test event 1 (sports)");
            SocialEvent socialEvent5 = new SocialEvent(7, 12, "Sports", "Test event 2 (sports)");
            SocialEvent socialEvent6 = new SocialEvent(9, 432, "Concert", "Test event 3 (concert)");
            SocialEvent socialEvent7 = new SocialEvent(5, 768, "Concert", "Test event 4 (concert)");
            SocialEvent socialEvent8 = new SocialEvent(7, 654, "Art", "Test event 5 (art)");
            SocialEvent socialEvent9 = new SocialEvent(9, 564, "TalentShow", "Test event 6 (talentShow)");

            context.SocialEvents.Add(socialEvent1);
            context.SocialEvents.Add(socialEvent2);
            context.SocialEvents.Add(socialEvent3);
            context.SocialEvents.Add(socialEvent4);
            context.SocialEvents.Add(socialEvent5);
            context.SocialEvents.Add(socialEvent6);
            context.SocialEvents.Add(socialEvent7);
            context.SocialEvents.Add(socialEvent8);
            context.SocialEvents.Add(socialEvent9);

            Ticket ticket1 = new Ticket(socialEvent1);
            Ticket ticket2 = new Ticket(socialEvent1);
            Ticket ticket3 = new Ticket(socialEvent1);
            Ticket ticket4 = new Ticket(socialEvent1);
            Ticket ticket5 = new Ticket(socialEvent2);
            Ticket ticket6 = new Ticket(socialEvent2);
            Ticket ticket7 = new Ticket(socialEvent2);
            Ticket ticket8 = new Ticket(socialEvent3);

            context.Tickets.Add(ticket1);
            context.Tickets.Add(ticket2);
            context.Tickets.Add(ticket3);
            context.Tickets.Add(ticket4);
            context.Tickets.Add(ticket5);
            context.Tickets.Add(ticket6);
            context.Tickets.Add(ticket7);
            context.Tickets.Add(ticket8);

            base.Seed(context);
        }
    }
}