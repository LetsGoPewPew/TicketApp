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
        private Ticket ticket;
        private SocialEvent socialEvent;

        [SetUp]
        public void SetupBeforeEachTest()
        {
            ticket = new Ticket(1, 1);
            socialEvent = new SocialEvent(1);
        }

        [Test]
        public void Assert_that_id_is_one()
        {
            Assert.AreEqual(ticket.Id, 1);
        }

        [Test]
        public void Assert_that_ticket_has_correct_event_when_verifying()
        {
            Assert.True(ticket.Verify(socialEvent.Id));
        }

        [Test]
        public void Assert_that_ticket_is_not_valid_after_verification()
        {
            ticket.Verify(socialEvent.Id);
            Assert.False(ticket.IsValid);
        }
    }
}
