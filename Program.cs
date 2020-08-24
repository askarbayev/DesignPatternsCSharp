using System;
using TaxService;
using OrderNM;
using InvoiceService;
using ShippingService;

namespace DesignPatternsCSharp
{
    class Program
    {
        static void Main(string[] args)
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
