using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TicketApp.Tests;
using Library.Model;

namespace TicketApp.Tests
{
    [TestFixture]
    public class TicketTests
    {
        [Test]
        public void Aseert_that_id_is_one()
        {
            Ticket t = new Ticket();
        }
    }
}
