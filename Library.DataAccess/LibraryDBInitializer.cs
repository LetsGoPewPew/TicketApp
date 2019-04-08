using Library.Model;
using System.Data.Entity;

namespace Library.DataAccess
{
    public class LibraryDBInitializer : DropCreateDatabaseIfModelChanges<MyDbContext>
    {
        protected override void Seed(MyDbContext context)
        {
            Customer customer1 = new Customer("1", "1", "1");

            context.Customers.Add(customer1);

            base.Seed(context);
        }
    }
}
