using Library.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess
{
    public class MyDbContext : DbContext
    {
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Organizer> Organizers { get; set; }
        public virtual DbSet<SocialEvent> SocialEvents { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }

        public MyDbContext(string connectionString, bool seedDatabase = true) : base (connectionString)
        {
            Configuration.ProxyCreationEnabled = false;

            Database.Connection.ConnectionString = connectionString;
            if(seedDatabase)
            {
                Database.SetInitializer(new DatabaseInitializer());
            }
        }
    }
}
