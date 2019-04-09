using Library.DataAccess;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApp.Tests
{
    [TestFixture]
    class DatabaseControllerTests
    {
        [Test]
        public void CreateDataContext_ReturnsDataContextObject()
        {
            MyDbContext result = DatabaseController.CreateDatabaseContext();
            Assert.IsNotNull(result);
        }
    }
}
