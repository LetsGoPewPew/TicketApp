using Library.Logic;
using Library.Model;
using NUnit.Framework;

namespace TicketApp.Tests
{
    [TestFixture]
    public class CustomerTests
    {
        private Customer customer;
        [SetUp]
        public void SetUp()
        {
            customer = new Customer("ole", "ole@ole.com", "passord");
        }

        [Test]
        public void Assert_customer_login()
        {
            Assert.True(UserLogic.Login("ole@ole.com", "passord"));
        }
    }
}
