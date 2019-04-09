using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess
{
    public class DatabaseContextCreator
    {
        public static MyDbContext CreateDatabaseContext()
        {
            return new MyDbContext(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Database;Integrated Security=True;Pooling=False");
        }

        public static MyDbContext CreateTestDatabaseContext()
        {
            return new MyDbContext(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TestDatabase;Integrated Security=True;Pooling=False", false);
        }
    }
}
