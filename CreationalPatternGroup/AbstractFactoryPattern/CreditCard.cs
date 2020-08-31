using System;

namespace DesignPatternsCSharp.AbstractFactoryPattern
{
    public class CreditCard
    {
        public long CardNumer;
        public DateTime CardExpireDate;
        public string CVV;
        public CardType CardType;
        public string NameOnCard;

        public CreditCard(long cardNumer, DateTime cardExpireDate, string cvv, CardType cardType, string nameOnCard)
        {
            this.CardNumer = cardNumer;
            this.CardExpireDate = cardExpireDate;
            this.CVV = cvv;
            this.CardType = cardType;
            this.NameOnCard = nameOnCard;
        }
    }
}