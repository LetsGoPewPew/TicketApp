using ApprovalTests;
using ApprovalTests.Reporters;
using Library.Model;
using Library.Payment;
using NUnit.Framework;

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
