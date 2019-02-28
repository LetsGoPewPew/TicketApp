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
        [Test]
        public void Assert_that_id_is_one()
        {
            Ticket t = new Ticket(1, 0);

            Assert.AreEqual(t.Id, 1);
        }

        [Test]
        public void Assert_that_ticket_has_correct_event_when_verifying()
        {
            Ticket ticket = new Ticket(1, 1);
            SocialEvent socialEvent = new SocialEvent(1);
            Assert.True(ticket.Verify(socialEvent.Id));
        }
    }
}
