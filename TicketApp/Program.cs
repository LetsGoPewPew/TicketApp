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

            MyDbContext context = DatabaseContextCreator.CreateDatabaseContext();
            DatabaseUnitOfWork unitOfWork = new DatabaseUnitOfWork(context);

            ITargetPersistenceAdapter persistenceAdapter = new AdapterGenericRepository(unitOfWork);

            IUnitOfWork adapterUnitOfWork = persistenceAdapter.GetUnitOfWork();

            Application.Run(new LoginForm(persistenceAdapter));
        }
    }
}
