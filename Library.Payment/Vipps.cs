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