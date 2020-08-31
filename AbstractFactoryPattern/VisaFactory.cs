using System;

namespace AbstractFactoryPattern
{
    public class VisaFactory : CreditCardFactory
    {
        public override CreditCard GetCreditCard(CardType cardType)
        {
            switch (cardType)
            {
                case CardType.GOLD:
                    return new VisaGoldCreditCard(1111111111111113, DateTime.Now.AddYears(6), "123", cardType, "Gleb Mathew");
                case CardType.PLATINUM:
                    return new VisaPlatinumCreditCard(1111111111111114, DateTime.Now.AddYears(6), "123", cardType, "Gleb Mathew");
                default:
                    return null;
            }
        }

    }
}