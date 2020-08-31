using System;

namespace DesignPatternsCSharp.AbstractFactoryPattern
{
    public class VisaGoldCreditCard : CreditCard
    {
        public VisaGoldCreditCard(long cardNumer, DateTime cardExpireDate, string cvv, CardType cardType, string nameOnCard)
                : base(cardNumer, cardExpireDate, cvv, cardType, nameOnCard) { }
    }
}