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
        public void CleanUp()
        {
            unitOfWork.Dispose();
        }
        static MyDbContext context = DatabaseContextCreator.CreateTestDatabaseContext();
        static UnitOfWork unitOfWork = new UnitOfWork(context);

        [Test]
        public void Assert_that_customer_exists_after_adding()
        {
            using (TransactionScope scope = new TransactionScope())
            { 
                Customer customer = new Customer("name1", "email1", "password1");

                unitOfWork.CustomerRepository.Add(customer);

                unitOfWork.Commit();

                Customer result = unitOfWork.CustomerRepository.Entities.First<Customer>();
            }
        }
    }
}
