using OrderNM;

namespace TaxService
{
    public interface ITaxServiceStrategy
    {
        decimal calculateTax(IOrder order);
    }
}