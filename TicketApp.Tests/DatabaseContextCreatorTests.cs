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
            MyDbContext result = DatabaseContextCreator.CreateDatabaseContext();
            Assert.IsNotNull(result);
            result.Dispose();
        }

        [Test]
        public void CreateTestDataContext_ReturnsDataContextObject()
        {
            MyDbContext result = DatabaseContextCreator.CreateTestDatabaseContext();
            Assert.IsNotNull(result);
            result.Dispose();
        }
    }
}
