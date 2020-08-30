using DesignPatternsCSharp.OrderNM;

namespace DesignPatternsCSharp.TaxService
{
    public interface ITaxServiceStrategy
    {
        decimal calculateTax(IOrder order);
    }
}