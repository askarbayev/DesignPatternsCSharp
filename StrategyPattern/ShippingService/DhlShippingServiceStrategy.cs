using System;

namespace DesignPatternsCSharp.ShippingService
{
    public class DhlShippingServiceStrategy : IShippingServiceStrategy
    {
        public void ship()
        {
            Console.WriteLine("Order shipped with DHL");
        }
    }
}