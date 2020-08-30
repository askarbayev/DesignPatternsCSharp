using System;

namespace DesignPatternsCSharp.ShippingService
{
    public class USPSShippingServiceStrategy : IShippingServiceStrategy
    {
        public void ship()
        {
            Console.WriteLine("Order shipped with USPS");
        }
    }
}