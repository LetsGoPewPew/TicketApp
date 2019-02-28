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

        [SetUp]
        public void SetupBeforeEachTest()
        {
            socialEvent1 = new SocialEvent();
            socialEvent2 = new SocialEvent();
            ticket1 = new Ticket(socialEvent1.Id);
            ticket2 = new Ticket(socialEvent2.Id);
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
    }
}
