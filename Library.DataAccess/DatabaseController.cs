using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess
{
    public class DatabaseController
    {
        public static MyDbContext CreateDatabaseContext()
        {
            return new MyDbContext(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TestDatabase2;Integrated Security=True;Pooling=False");
        }

        public static MyDbContext CreateTestDatabaseContext()
        {
            return new MyDbContext(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FakeDatabase;Integrated Security=True;Pooling=False");
        }
    }
}
