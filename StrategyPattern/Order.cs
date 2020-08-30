using DesignPatternsCSharp.TaxService;
using DesignPatternsCSharp.InvoiceService;
using System;
using DesignPatternsCSharp.ShippingService;

namespace DesignPatternsCSharp.OrderNM
{
    public class Order : IOrder
    {
        public string origin { get; set; }
        public string destination { get; set; }
        public ITaxServiceStrategy taxService { get; set; }
        public IInvoiceServiceStrategy invoiceService { get; set; }
        public IShippingServiceStrategy shippingService { get; set; }
        public IItem[] items { get; set; }
        public decimal getTax()
        {
            if (taxService == null)
            {
                return 0.0m;
            }
            return taxService.calculateTax(this);
        }

        public void GenerateInvoice()
        {
            if (invoiceService == null)
            {
                Console.WriteLine("No Invoice Service Found");
            }

            invoiceService.Generate(this);
        }

        public void ShipOrder()
        {
            if (shippingService == null)
            {
                Console.WriteLine("No Shipping Service Found");
            }

            shippingService.ship();
        }
    }
}