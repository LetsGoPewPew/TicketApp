using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Payment
{
    public class Vipps : PaymentMethod, IPaymentMethod
    {
        public bool PayForItem(string item, int price)
        {
            return true;
        }

        public override string ToString()
        {
            return "Vipps";
        }

    }
}