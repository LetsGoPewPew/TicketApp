using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model;
using NUnit.Framework;

namespace TicketApp.Tests
{
    [TestFixture]
    class UserLogicTests
    {
        private Customer customer1, customer2;
        [SetUp]
        public void SetupBeforeEachTest()
        {
            customer1 = new Customer("name1", "email1", "password1");
            customer2 = new Customer("name2", "email2", "password2");
        }

        [Test]
        public void Assert_that_unregistered_user_does_not_have_access()
        {
            Assert.False(UserLogic.Login("randomText", "randomText"));
        }

        [Test]
        public void Assert_that_registered_user_has_access()
        {
            Assert.True(UserLogic.Login(customer1.Email, customer1.Password));
        }
    }
}
