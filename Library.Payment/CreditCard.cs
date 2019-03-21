using System;

namespace Library.Payment
{
    public class CreditCard : IPayment
    {
        public bool PayForItem(string item, int price)
        {
            Console.WriteLine("CreditCard");
            return true;
        }
        public override string ToString()
        {
            return "Credit card";
        }
    }
}
