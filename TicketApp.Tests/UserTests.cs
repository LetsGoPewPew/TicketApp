using Library.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApp.Tests
{
    [TestFixture]
    public class UserTests
    {
        [Test]
        public void Assert_customer_created()
        {
            Customer customer = new Customer("ole", "ole@ole.com", "passord");
            Assert.IsNotEmpty(Customer.UserList);

        }

        [Test]
        public void Assert_customer_login()
        {
            Customer customer = new Customer("ole", "ole@ole.com", "passord");
            Assert.True(Customer.Login("ole@ole.com", "passord"));
        }
    }
}