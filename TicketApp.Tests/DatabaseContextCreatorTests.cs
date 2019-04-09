using Library.DataAccess;
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
    class DatabaseContextCreatorTests
    {
        [Test]
        public void CreateDataContext_ReturnsDataContextObject()
        {
            using(TransactionScope scope = new TransactionScope())
            {
                MyDbContext result = DatabaseContextCreator.CreateDatabaseContext();
                Assert.IsNotNull(result);
            }
        }

        [Test]
        public void CreateTestDataContext_ReturnsDataContextObject()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                MyDbContext result = DatabaseContextCreator.CreateTestDatabaseContext();
                Assert.IsNotNull(result);
            }
        }
    }
}
