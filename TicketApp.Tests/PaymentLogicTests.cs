using Library.Payment;
using NUnit.Framework;

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