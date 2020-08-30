using DesignPatternsCSharp.OrderNM;

namespace DesignPatternsCSharp.InvoiceService
{
    public interface IInvoiceServiceStrategy
    {
        void Generate(IOrder order);
    }
}