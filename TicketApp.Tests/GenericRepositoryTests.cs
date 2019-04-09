﻿using Library.Persistency;
using Library.Model;
using NUnit.Framework;
using Library.DataAccess;
using System.Linq;
using System.Transactions;

namespace TicketApp.Tests
{
    [TestFixture]
    class GenericRepositoryTests
    {
        private static MyDbContext context = DatabaseContextCreator.CreateTestDatabaseContext();
        private static GenericRepository<Customer> Customers = new GenericRepository<Customer>(context);
        private Customer customer;

        [SetUp]
        public void SetupBeforeEachTest()
        {
            customer = new Customer("Ole", "ole@gmail.com", "rallysjåfør");
        }

        [Test]
        public void Assert_add_to_generic_repository()
        {
            using(TransactionScope scope = new TransactionScope())
            {
                Customers.Add(customer);
                context.SaveChanges();

                Assert.IsNotEmpty(Customers.Entities.ToList());
            }
        }

        [Test]
        public void Assert_remove_to_generic_repository()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                Customers.Add(customer);
                context.SaveChanges();

                Customers.Remove(customer);
                context.SaveChanges();
                Assert.IsEmpty(Customers.Entities.ToList());
            }
        }
    }
}