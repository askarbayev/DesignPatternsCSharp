using System;

namespace ShippingService
{
    public class USPSShippingServiceStrategy : IShippingServiceStrategy
    {
        public void ship()
        {
            Console.WriteLine("Order shipped with USPS");
        }
    }
}