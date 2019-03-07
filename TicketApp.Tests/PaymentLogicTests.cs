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
        private PaymentLogic paymentLogic;
        private CreditCard creditCard;
        private Vips vips;

        [SetUp]
        public void SetupBeforeEachTest()
        {
            paymentLogic = new PaymentLogic();
            creditCard = new CreditCard();
            vips = new Vips();
        }

        [Test]
        public void Assert_creditcard_can_pay()
        {
            Assert.True(paymentLogic.Pay(creditCard, "item", 100));
        }

        [Test]
        public void Assert_vips_can_pay()
        {
            Assert.True(paymentLogic.Pay(vips, "item", 100));
        }
    }
}