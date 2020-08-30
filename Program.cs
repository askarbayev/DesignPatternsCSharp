using System;
using DesignPatternsCSharp.TaxService;
using DesignPatternsCSharp.OrderNM;
using DesignPatternsCSharp.InvoiceService;
using DesignPatternsCSharp.ShippingService;

namespace DesignPatternsCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // strategy pattern test
            StrategyPatternTest();
        }

        static void StrategyPatternTest()
        {
            IOrder order = new Order
            {
                origin = "IL",
                destination = "MA",
                items = new Item[] { new Item { name = "Phone", value = 800.0m }, new Item { name = "TV", value = 500.0m } },
                taxService = new USTaxService(),
                invoiceService = new DisplayInvoiceServiceStrategy(),
                shippingService = new FedExShippingServiceStrategy()
            };

            decimal tax = order.getTax();
            Console.WriteLine(tax);
            order.GenerateInvoice();
            order.ShipOrder();
        }

    }
}
