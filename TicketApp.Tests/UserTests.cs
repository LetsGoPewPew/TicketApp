using Library.Model;
using NUnit.Framework;

namespace TicketApp.Tests
{
    [TestFixture]
    public class UserTests
    {
        private Customer customer;

        [SetUp]
        public void SetupBeforeEachTest()
        {
            customer = new Customer("ole", "ole@ole.com", "passord");
        }

        [Test]
        public void Assert_customer_created()
        {
            Assert.IsNotEmpty(Customer.CustomerList);
        }

        [Test]
        public void Assert_customer_login()
        {
            Assert.True(Customer.Login("ole@ole.com", "passord"));
        }

        [Test]
        public void Assert_customer_cannot_have_same_email()
        {
            Assert.True(Customer.EmailInUse("ole@ole.com"));
        }
    }
}