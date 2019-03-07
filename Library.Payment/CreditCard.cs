namespace Library.Payment
{
    public class CreditCard : IPayment
    {
        public bool PayForItem(string item, int price)
        {
            return true;
        }
    }
}
