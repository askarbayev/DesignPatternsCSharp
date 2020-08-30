using System;

namespace DesignPatternsCSharp.ShippingService
{
    public class FedExShippingServiceStrategy : IShippingServiceStrategy
    {
        public void ship()
        {
            Console.WriteLine("Order shipped with FedEx");
        }
    }
}