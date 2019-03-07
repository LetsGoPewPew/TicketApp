using Library.Logic;
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
        public void Assert_user_cannot_have_same_email()
        {
            Assert.True(UserLogic.EmailInUse("ole@ole.com"));
        }

        [Test]
        public void Assert_user_not_same_id()
        {
            Customer customer2 = new Customer("hans", "hans@hans.com", "passord2");
            Assert.AreNotEqual(customer.Id, customer2.Id);
        }
    }
}