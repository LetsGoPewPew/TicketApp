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
        private CreditCard creditCard;
        private int numberOfTickets;

        [SetUp]
        public void SetupBeforeEachTest()
        {
            numberOfTickets = 10;
            socialEvent = new SocialEvent(numberOfTickets, 1);
            creditCard = new CreditCard("123","123","123","123");
        }

        [Test]
        public void Assert_that_amount_of_remaining_tickets_is_correct_after_one_has_been_sold()
        {
            socialEvent.BuyTickets(1, creditCard);
            Assert.AreEqual( (numberOfTickets - 1), socialEvent.GetAmountOfAvailableTickets());
        }
    }
}
