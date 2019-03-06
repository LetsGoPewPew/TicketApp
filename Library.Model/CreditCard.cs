namespace Library.Model
{
    public class CreditCard
    {
        private string cardNumber;
        public string CardNumber { get => cardNumber; set => cardNumber = value; }

        private string cardCode;
        public string CardCode { get => cardCode; set => cardCode = value; }

        private int expirationDay;
        public int ExpirationDay { get => expirationDay; set => expirationDay = value; }

        private int expirationMonth;
        public int ExpirationDate { get => expirationMonth; set => expirationMonth = value; }

        private int moneyAvailable;
        public int MoneyAvailable { get => moneyAvailable; set => moneyAvailable = value; }


        public CreditCard(string cardNumber, string cardCode, int expirationDay, int expirationMonth, int moneyAvailable)
        {
            this.cardNumber = cardNumber;
            this.cardCode = cardCode;
            this.expirationDay = expirationDay;
            this.expirationMonth = expirationMonth;
            this.moneyAvailable = moneyAvailable;
        }

    }
}
