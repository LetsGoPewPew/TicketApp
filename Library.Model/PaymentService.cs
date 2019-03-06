using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    class PaymentService
    {
        private CreditCard creditCard;
        public  CreditCard CreditCard { get => creditCard; set => creditCard = value; }

        private int priceToPay;
        public int PriceToPay { get => priceToPay; private set => priceToPay = value; }

        public PaymentService(CreditCard creditCard, int priceToPay)
        {
            this.creditCard = creditCard;
            this.priceToPay = priceToPay;
        }

        public bool VerifyPayment()
        {
            if (creditCard.MoneyAvailable >= priceToPay)
            {
                creditCard.MoneyAvailable -= priceToPay;
                return true;
            }
            return false;
        }
    }
 
}
