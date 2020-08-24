using System;

namespace ShippingService
{
    public class DhlShippingServiceStrategy : IShippingServiceStrategy
    {
        public void ship()
        {
            Console.WriteLine("Order shipped with DHL");
        }
    }
}