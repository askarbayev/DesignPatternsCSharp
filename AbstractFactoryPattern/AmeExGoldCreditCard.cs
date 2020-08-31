using System;

namespace AbstractFactoryPattern
{
    public class AmeExGoldCreditCard : CreditCard
    {
        public AmeExGoldCreditCard(long cardNumer, DateTime cardExpireDate, string cvv, CardType cardType, string nameOnCard)
        : base(cardNumer, cardExpireDate, cvv, cardType, nameOnCard) { }
    }
}