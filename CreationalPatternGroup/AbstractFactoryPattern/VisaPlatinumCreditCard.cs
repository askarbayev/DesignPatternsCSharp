using System;

namespace DesignPatternsCSharp.AbstractFactoryPattern
{
    public class VisaPlatinumCreditCard : CreditCard
    {
        public VisaPlatinumCreditCard(long cardNumer, DateTime cardExpireDate, string cvv, CardType cardType, string nameOnCard)
                : base(cardNumer, cardExpireDate, cvv, cardType, nameOnCard) { }
    }
}