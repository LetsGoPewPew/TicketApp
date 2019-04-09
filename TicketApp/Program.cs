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

            MyDbContext context = DatabaseContextCreator.CreateDatabaseContext();
            UnitOfWork unitOfWork = new UnitOfWork(context);
            AdapterGenericRepository agr = new AdapterGenericRepository(unitOfWork);
            agr.GetAll(agr.UnitOfWorkRepository.CustomerRepository).ToList();
            agr.GetAll(agr.UnitOfWorkRepository.OrganizerRepository).ToList();
            agr.GetAll(agr.UnitOfWorkRepository.SocialEventRepository).ToList();
            agr.GetAll(agr.UnitOfWorkRepository.TicketRepository).ToList();

            Application.Run(new LoginForm());
        }
    }
}
