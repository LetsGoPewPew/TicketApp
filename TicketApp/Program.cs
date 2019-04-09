using Library.DataAccess;
using Library.Model;
using Library.PersistenceAdapter;
using Library.Persistency;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace TicketApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /*
            // https://stackoverflow.com/questions/21563940/how-to-connect-to-localdb-in-visual-studio-server-explorer
            MyDbContext context = new MyDbContext(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TestDatabase2;Integrated Security=True;Pooling=False");
            UnitOfWork unitOfWork = new UnitOfWork(context);
            */

            MyDbContext context = DatabaseController.CreateDatabaseContext();
            UnitOfWork unitOfWork = new UnitOfWork(context);
            AdapterGenericRepository agr = new AdapterGenericRepository(unitOfWork);
            List<Customer> customers = agr.GetAll(agr.UnitOfWorkRepository.CustomerRepository).ToList();

            foreach(Customer c in customers)
            {
                Console.WriteLine(c);
            }
            List<Organizer> organizers = agr.GetAll(agr.UnitOfWorkRepository.OrganizerRepository).ToList();
            foreach(Organizer o in organizers)
            {
                Console.WriteLine(o);
            }


            Application.Run(new LoginForm());
        }
    }
}
