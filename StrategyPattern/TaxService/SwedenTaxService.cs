using DesignPatternsCSharp.OrderNM;

namespace DesignPatternsCSharp.TaxService
{
    public class SwedenTaxService : ITaxServiceStrategy
    {
        public decimal calculateTax(IOrder order)
        {
            decimal totalTax = 0.0m;
            decimal taxPercent = 5.0m;

            foreach (IItem item in order.items)
            {
                totalTax += (item.value * taxPercent) / 100;
            }

            return totalTax;
        }
    }
}