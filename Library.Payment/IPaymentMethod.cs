namespace Library.Payment
{
    public interface IPaymentMethod
    {
        bool PayForItem(string item, int price);
    }
}