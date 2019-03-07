using Library.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Logic
{
    public class SocialEventLogic
    {
        public static bool BuyTickets<T>(T paymentMethod, int amountOfTickets, int pricePerTicket) where T : IPayment
        {
            int totalPrice = amountOfTickets * pricePerTicket;
            return paymentMethod.PayForItem("item", totalPrice);
        }
    }
}
