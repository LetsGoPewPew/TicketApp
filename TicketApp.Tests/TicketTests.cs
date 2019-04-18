using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TicketApp.Tests;
using Library.Model;
using NUnit.Framework.Internal.Execution;

namespace TicketApp.Tests
{
    [TestFixture]
    public class TicketTests
    {
        private Ticket ticket1;
        private Ticket ticket2;
        private SocialEvent socialEvent1;
        private SocialEvent socialEvent2;
        private Organizer organizer;

        [SetUp]
        public void SetUp()
        {
            organizer = new Organizer();
            socialEvent1 = new SocialEvent(10, 100, organizer);
            socialEvent2 = new SocialEvent(10, 100, organizer);
            ticket1 = new Ticket(socialEvent1);
            ticket2 = new Ticket(socialEvent2);
        }

        [Test]
        public void Assert_that_multiple_tickets_have_different_id()
        {
            Assert.AreNotEqual(ticket1.Id, ticket2.Id);
        }

        [Test]
        public void Assert_that_ticket_has_correct_event_when_verifying()
        {
            Assert.True(ticket1.Verify(socialEvent1.Id));
        }

        [Test]
        public void Assert_that_ticket_is_not_valid_after_verification_is_successfull()
        {
            ticket1.Verify(socialEvent1.Id);
            Assert.False(ticket1.IsValid);
        }

        [Test]
        public void Assert_that_ticket_is_added_to_the_social_events_list_of_tickets()
        {
            Assert.Contains(ticket1 , socialEvent1.TicketsForThisSocialEvent);
        }
    }
}
