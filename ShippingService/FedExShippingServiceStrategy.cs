using System;

namespace ShippingService
{
    public class FedExShippingServiceStrategy : IShippingServiceStrategy
    {
        public void ship()
        {
            Console.WriteLine("Order shipped with FedEx");
        }
    }
}