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
        private DatabaseUnitOfWork unitOfWork;
        private TransactionScope scope;
        private Customer customer;

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            unitOfWork.Dispose();
        }

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            context = DatabaseContextCreator.CreateTestDatabaseContext();
            unitOfWork = new DatabaseUnitOfWork(context);
            context.Database.CreateIfNotExists();
        }

        [SetUp]
        public void SetUp()
        {
            scope = new TransactionScope();
            customer = new Customer("name1", "email1", "password1");
        }

        [TearDown]
        public void TearDown()
        {
            scope.Dispose();
        }

        [Test]
        public void Assert_that_customer_exists_after_adding()
        {

            unitOfWork.CustomerRepository.Add(customer);

            unitOfWork.Commit();

            List<Customer> result = unitOfWork.CustomerRepository.Entities.ToList<Customer>();

            Assert.IsNotEmpty(result);
        }

        [Test]
        public void Assert_database_empty_after_adding_then_removing()
        {
            unitOfWork.CustomerRepository.Add(customer);

            unitOfWork.Commit();

            unitOfWork.CustomerRepository.Remove(customer);

            unitOfWork.Commit();

            List<Customer> result = unitOfWork.CustomerRepository.Entities.ToList<Customer>();

            Assert.IsEmpty(result);

        }

        [Test]
        public void Assert_database_empty_after_adding_then_rejecting_changes()
        {

            unitOfWork.CustomerRepository.Add(customer);

            unitOfWork.RejectChanges();

            unitOfWork.Commit();

            List<Customer> result = unitOfWork.CustomerRepository.Entities.ToList<Customer>();

            Assert.IsEmpty(result);
        }
    }
}
