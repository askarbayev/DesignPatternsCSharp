namespace AbstractFactoryPattern
{
    /// <summary>
    /// this is the abstract factory class which has a method to return normal factory object.
    /// the other method is just a abstract factory method whuch is implemented by subclasses
    /// </summary>
    public abstract class CreditCardFactory
    {
        public static CreditCardFactory GetCreditCardFactory(int creditScore)
        {
            switch (creditScore)
            {
                case 600:
                    return new AmeExFactory();
                case 700:
                    return new VisaFactory();
                default:
                    return null;
            }
        }

        public abstract CreditCard GetCreditCard(CardType cardType);
    }
}