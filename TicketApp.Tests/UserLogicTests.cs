using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Logic;
using Library.Model;
using NUnit.Framework;

namespace TicketApp.Tests
{
    [TestFixture]
    class UserLogicTests
    {
        private Customer customer1;
        [SetUp]
        public void SetUp()
        {
            customer1 = new Customer("name1", "email1", "password1");
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

        [Test]
        public void Assert_that_user_can_authorize()
        {
            Assert.True(UserLogic.Authorize("email1", "password1"));
        }

        [Test]
        public void Assert_upgrade_customer()
        {
            Organizer newOrganizer = UserLogic.UpgradeCustomer(customer1);
            Assert.True(newOrganizer.GetType() == typeof(Organizer));
        }

        [Test]
        public void Assert_upgrade_customer_deleted_from_customer_list()
        {
            Organizer newOrganizer = UserLogic.UpgradeCustomer(customer1);
            Assert.IsNotEmpty(Customer.CustomerList);
        }
    }
}
