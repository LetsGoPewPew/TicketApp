using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model;
using NUnit.Framework;

namespace TicketApp.Tests
{
    [TestFixture]
    class SocialEventTests
    {
        private SocialEvent socialEvent;
        private Ticket ticket1, ticket2, ticket3;

        [SetUp]
        public void SetupBeforeEachTest()
        {
            socialEvent = new SocialEvent(10);
            ticket1 = new Ticket(socialEvent);
            ticket2 = new Ticket(socialEvent);
            ticket3 = new Ticket(socialEvent);
        }

        [Test]
        public void Assert_that_amount_of_remaining_tickets_is_correct()
        {
            Assert.AreEqual(7, socialEvent.GetAmountOfAvailableTickets());
        }
    }
}
