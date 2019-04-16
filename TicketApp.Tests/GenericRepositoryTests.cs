using Library.Persistency;
using Library.Model;
using NUnit.Framework;
using Library.DataAccess;
using System.Linq;
using System.Transactions;
using System.Collections.Generic;

namespace TicketApp.Tests
{
    [TestFixture]
    class GenericRepositoryTests
    {
        private MyDbContext context;
        private DatabaseGenericRepository<Customer> customers;
        private TransactionScope scope;
        private Customer customer;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            context = DatabaseContextCreator.CreateTestDatabaseContext();
            customers = new DatabaseGenericRepository<Customer>(context);
            context.Database.CreateIfNotExists();
        }

        [SetUp]
        public void SetUp()
        {
            customer = new Customer("Ole", "ole@gmail.com", "rallysjåfør");
            scope = new TransactionScope();
        }

        [TearDown]
        public void TearDown()
        {
            scope.Dispose();
        }

        [Test]
        public void Assert_add_to_generic_repository()
        {
            customers.Add(customer);
            context.SaveChanges();

            Assert.IsNotEmpty(customers.Entities.ToList());
        }

        [Test]
        public void Assert_remove_to_generic_repository()
        {
            customers.Add(customer);

            customers.Remove(customer);
            context.SaveChanges();
            List<Customer> result = customers.Entities.ToList<Customer>();

            Assert.IsEmpty(result);
        }
    }
}
