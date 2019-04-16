using Library.DataAccess;
using Library.Model;
using Library.PersistenceAdapter;
using Library.Persistency;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace TicketApp.Tests
{
    [TestFixture]
    class AdapterGenericRepositoryTests
    {
        private MyDbContext context;
        private TransactionScope scope;
        private AdapterGenericRepository adapter;
        private Customer customer;
        private DatabaseUnitOfWork unitOfWork;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            context = DatabaseContextCreator.CreateTestDatabaseContext();
            context.Database.CreateIfNotExists();
            unitOfWork = new DatabaseUnitOfWork(context);
        }

        [SetUp]
        public void SetUp()
        {
            customer = new Customer("Ole", "ole@gmail.com", "rallysjåfør");
            scope = new TransactionScope();
            adapter = new AdapterGenericRepository(unitOfWork);
        }

        [TearDown]
        public void TearDown()
        {
            scope.Dispose();
        }

        [Test]
        public void Assert_that_customer_exists_after_adding()
        {
            adapter.Add(adapter.GetUnitOfWork().CustomerRepository, customer);

            adapter.Save();

            List<Customer> result = adapter.GetAll<Customer>(adapter.GetUnitOfWork().CustomerRepository).ToList<Customer>();

            Assert.IsNotEmpty(result);
        }

        [Test]
        public void Assert_database_empty_after_adding_then_removing()
        {
            adapter.Add(adapter.GetUnitOfWork().CustomerRepository, customer);

            adapter.Save();

            adapter.Remove<Customer>(adapter.GetUnitOfWork().CustomerRepository, customer);

            adapter.Save();

            List<Customer> result = adapter.GetAll<Customer>(adapter.GetUnitOfWork().CustomerRepository).ToList<Customer>();

            Assert.IsEmpty(result);
        }

        [Test]
        public void Assert_database_empty_after_adding_then_rejecting_changes()
        {
            adapter.Add(adapter.GetUnitOfWork().CustomerRepository, customer);

            adapter.Undo();

            adapter.Save();

            List<Customer> result = adapter.GetAll<Customer>(adapter.GetUnitOfWork().CustomerRepository).ToList<Customer>();

            Assert.IsEmpty(result);
        }

    }
}
