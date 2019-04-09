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
        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            unitOfWork.Dispose();
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

        static MyDbContext context = DatabaseContextCreator.CreateTestDatabaseContext();
        static UnitOfWork unitOfWork = new UnitOfWork(context);
        private static TransactionScope scope = new TransactionScope();

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
