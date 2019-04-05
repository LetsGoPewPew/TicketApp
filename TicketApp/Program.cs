using Library.Model;
using Library.Persistency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FillTestData();
            Application.Run(new LoginForm());
        }

        private static void FillTestData()
        {
            Customer customer1 = new Customer("1", "1", "1");
            Customer customer2 = new Customer("2", "2", "2");
            Organizer organizer1 = new Organizer("3", "3", "3");

            // TODO: Remove this
            FakeListPersist flp = new FakeListPersist();
            PersistentProcess<FakeListPersist> pp = new PersistentProcess<FakeListPersist>(flp);
            pp.Customers.List.Add(customer1);
            pp.Customers.List.Add(customer2);


            SocialEvent socialEvent1 = new SocialEvent(5, 133, "Art", "Kristine og Ramona synger bæ bæ lille lam");
            SocialEvent socialEvent2 = new SocialEvent(7, 5643, "Sports", "Stian og Jørgen Sjonglerer med datamus");
            SocialEvent socialEvent3 = new SocialEvent(9, 2312, "TalentShow", "Juan kjører solo dukkeshow");
            SocialEvent socialEvent4 = new SocialEvent(5, 436, "Sports", "Test event 1 (sports)");
            SocialEvent socialEvent5 = new SocialEvent(7, 12, "Sports", "Test event 2 (sports)");
            SocialEvent socialEvent6 = new SocialEvent(9, 432, "Concert", "Test event 3 (concert)");
            SocialEvent socialEvent7 = new SocialEvent(5, 768, "Concert", "Test event 4 (concert)");
            SocialEvent socialEvent8 = new SocialEvent(7, 654, "Art", "Test event 5 (art)");
            SocialEvent socialEvent9 = new SocialEvent(9, 564, "TalentShow", "Test event 6 (talentShow)");

            Ticket ticket1 = new Ticket(socialEvent1);
            Ticket ticket2 = new Ticket(socialEvent1);
            Ticket ticket3 = new Ticket(socialEvent1);
            Ticket ticket4 = new Ticket(socialEvent1);
            Ticket ticket5 = new Ticket(socialEvent2);
            Ticket ticket6 = new Ticket(socialEvent2);
            Ticket ticket7 = new Ticket(socialEvent2);
            Ticket ticket8 = new Ticket(socialEvent3);
        }
    }
}
