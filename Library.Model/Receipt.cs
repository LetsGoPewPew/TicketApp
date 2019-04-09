using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class Receipt
    {
        private readonly int numberOfTickets;
        private readonly string currencyTypeSuffix;
        private readonly string paymentMethod;
        private Ticket ticket;

        public Receipt(int numberOfTickets, Ticket ticket, string currencyTypeSuffix, string paymentMethod)
        {
            this.ticket = ticket;
            this.numberOfTickets = numberOfTickets;
            this.currencyTypeSuffix = currencyTypeSuffix;
            this.paymentMethod = paymentMethod;
        }

        public string GenerateReceipt()
        {
            int pricePerTicket = ticket.SocialEvent.PricePerTicket;
            StringBuilder stringbuilder = new StringBuilder();
            stringbuilder.AppendLine("Ticket(s) for: " + ticket.SocialEvent.Name);
            stringbuilder.AppendLine("Number of tickets: " + numberOfTickets);
            stringbuilder.AppendLine("Price per ticket: " + pricePerTicket + "kr");
            stringbuilder.AppendLine("Price total: " + (pricePerTicket * numberOfTickets) + currencyTypeSuffix);
            stringbuilder.Append("Paid using: " + paymentMethod);
            return stringbuilder.ToString();
        }

    }
}
