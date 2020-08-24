using OrderNM;

namespace InvoiceService
{
    public interface IInvoiceServiceStrategy
    {
        void Generate(IOrder order);
    }
}