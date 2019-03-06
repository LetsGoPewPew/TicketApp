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

        public PaymentService(CreditCard creditCard)
        {
            this.creditCard = creditCard;
        }

        public bool VerifyPayment()
        {
            if (creditCard.CardNumber == "123")
            {
                return true;
            }

            return false;
        }
    }
 
}
