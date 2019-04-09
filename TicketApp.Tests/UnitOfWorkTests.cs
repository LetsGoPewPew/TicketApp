using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model;
using Library.DataAccess;
using Library.Persistency;
using System.Transactions;

namespace TicketApp.Tests
{
    [TestFixture]
    class UnitOfWorkTests
    {

        private MyDbContext context;
        private UnitOfWork unitOfWork;
        private TransactionScope scope;

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            unitOfWork.Dispose();
        }

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            context = DatabaseContextCreator.CreateTestDatabaseContext();
            unitOfWork = new UnitOfWork(context);
            context.Database.CreateIfNotExists();
        }

        [SetUp]
        public void SetUp()
        {
            scope = new TransactionScope();
        }

        [TearDown]
        public void TearDown()
        {
            scope.Dispose();
        }

        [Test]
        public void Assert_that_customer_exists_after_adding()
        {
            Customer customer = new Customer("name1", "email1", "password1");

            unitOfWork.CustomerRepository.Add(customer);

            unitOfWork.Commit();

            List<Customer> result = unitOfWork.CustomerRepository.Entities.ToList<Customer>();

            Assert.IsNotEmpty(result);
        }
    }
}
