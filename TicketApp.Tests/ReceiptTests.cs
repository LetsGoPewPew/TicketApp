using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model;
using ApprovalTests;
using ApprovalTests.Reporters;

namespace TicketApp.Tests
{
    [UseReporter(typeof(VisualStudioReporter))]
    [TestFixture]
    class ReceiptTests
    {
        [Test]
        public void Assert_reciept_is_correct()
        {
            SocialEvent socialEvent = new SocialEvent(10, 100, "TestCategory", "TestName");
            Ticket ticket = new Ticket(socialEvent);
            Receipt receipt = new Receipt(4, ticket, "kr");
            string result = receipt.GenerateReceipt();

            Approvals.Verify(result);
        }
    }
}
