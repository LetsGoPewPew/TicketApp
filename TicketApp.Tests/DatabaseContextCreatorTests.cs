using Library.DataAccess;
using NUnit.Framework;

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
