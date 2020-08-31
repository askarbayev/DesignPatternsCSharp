using System;

namespace DesignPatternsCSharp.AbstractFactoryPattern
{
    public class AmeExPlatinumCreditCard : CreditCard
    {
        public AmeExPlatinumCreditCard(long cardNumer, DateTime cardExpireDate, string cvv, CardType cardType, string nameOnCard)
        : base(cardNumer, cardExpireDate, cvv, cardType, nameOnCard) { }

    }
}