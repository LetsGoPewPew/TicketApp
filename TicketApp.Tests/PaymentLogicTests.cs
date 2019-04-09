using Library.Logic;
using Library.Payment;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApp.Tests
{
    [TestFixture]
    public class PaymentLogicTests
    {
        private CreditCard creditCard;
        private Vipps vipps;

        [SetUp]
        public void SetUp()
        {
            creditCard = new CreditCard();
            vipps = new Vipps();
        }

        [Test]
        public void Assert_creditcard_can_pay()
        {
            Assert.True(creditCard.PayForItem("item", 100));
        }

        [Test]
        public void Assert_vipps_can_pay()
        {
            Assert.True(vipps.PayForItem("item", 100));
        }
    }
}