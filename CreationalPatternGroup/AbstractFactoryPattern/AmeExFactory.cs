using System;

namespace DesignPatternsCSharp.AbstractFactoryPattern
{
    public class AmeExFactory : CreditCardFactory
    {
        public override CreditCard GetCreditCard(CardType cardType)
        {
            switch (cardType)
            {
                case CardType.GOLD:
                    return new AmeExGoldCreditCard(1111111111111111, DateTime.Now.AddYears(6), "123", cardType, "Gleb Mathew");
                case CardType.PLATINUM:
                    return new AmeExPlatinumCreditCard(1111111111111112, DateTime.Now.AddYears(6), "123", cardType, "Gleb Mathew");
                default:
                    return null;
            }
        }
    }
}