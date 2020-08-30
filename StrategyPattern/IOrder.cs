using DesignPatternsCSharp.TaxService;
using DesignPatternsCSharp.InvoiceService;
using DesignPatternsCSharp.ShippingService;

namespace DesignPatternsCSharp.OrderNM
{
    public interface IOrder
    {
        string origin { get; set; }
        string destination { get; set; }
        ITaxServiceStrategy taxService { get; set; }
        IInvoiceServiceStrategy invoiceService { get; set; }
        IShippingServiceStrategy shippingService { get; set; }
        IItem[] items { get; set; }
        decimal getTax();
        void GenerateInvoice();
        void ShipOrder();
    }
}