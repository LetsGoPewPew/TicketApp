using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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
        private int numberOfTickets;
        private Organizer organizer;

        [SetUp]
        public void SetUp()
        {
            organizer = new Organizer();
            numberOfTickets = 10;
            socialEvent = new SocialEvent(numberOfTickets, 1 , organizer);
        }

        [Test]
        public void Assert_socialEvent_created()
        {
            Assert.IsNotEmpty(SocialEvent.SocialEventList);
        }
    }
}
