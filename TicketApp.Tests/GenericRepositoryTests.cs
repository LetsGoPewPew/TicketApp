using Library.Persistency;
using Library.Model;
using NUnit.Framework;
using Library.DataAccess;

namespace TicketApp.Tests
{
    [TestFixture]
    class GenericRepositoryTests
    {
        private GenericRepository<Customer> Customers;
        [SetUp]
        public void SetupBeforeEachTest()
        {
            Customers = new GenericRepository<Customer>(new MyDbContext("a"));
        }

        [Test]
        public void Assert_add_and_remove_to_generic_repository()
        {
            Customer testCustomer = new Customer("1", "1", "1");
            Customers.Add(testCustomer);
            Assert.IsNotNull(Customers);

            Customers.Remove(testCustomer);
            Assert.NotNull(Customers)
        }
    }
}
