using System;

namespace Library.Model
{
    public class CreditCard
    {
        private string cardNumber;
        public string CardNumber { get => cardNumber; set => cardNumber = value; }

        private string cardCode;
        public string CardCode { get => cardCode; set => cardCode = value; }

        private string expirationYear;
        public string ExpirationDay { get => expirationYear; set => expirationYear = value; }

        private string expirationMonth;
        public string ExpirationMonth { get => expirationMonth; set => expirationMonth = value; }

        private int moneyAvailable;
        public int MoneyAvailable { get => moneyAvailable; set => moneyAvailable = value; }

        public CreditCard(string cardNumber, string cardCode, string expirationMonth, string expirationYear)
        {
            this.cardNumber = cardNumber;
            this.cardCode = cardCode;
            this.expirationYear = expirationYear;
            this.expirationMonth = expirationMonth;
            moneyAvailable = 10000;
        }

    }
}
