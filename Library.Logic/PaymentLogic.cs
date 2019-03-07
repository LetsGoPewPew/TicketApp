using Library.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Logic
{
    public class PaymentLogic
    {
        public bool Pay<T>(T paymentMethod, string item, int price) where T : IPayment
        {
            return paymentMethod.PayForItem(item, price);
        }
    }
}