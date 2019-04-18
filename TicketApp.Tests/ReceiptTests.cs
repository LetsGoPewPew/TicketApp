using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model;
using ApprovalTests;
using ApprovalTests.Reporters;
using Library.Payment;

namespace TicketApp.Tests
{
    [UseReporter(typeof(VisualStudioReporter))]
    [TestFixture]
    class ReceiptTests
    {

        [Test]
        public void Assert_receipt_is_correct()
        {
            Organizer organizer = new Organizer();
            SocialEvent socialEvent = new SocialEvent(10, 100, organizer ,"TestCategory", "TestName");
            Ticket ticket = new Ticket(socialEvent);
            Vipps vipps = new Vipps();
            Receipt receipt = new Receipt(4, ticket, "kr", vipps.ToString());
            string result = receipt.GenerateReceipt();

            Approvals.Verify(result);
        }
    }
}
