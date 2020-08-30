using DesignPatternsCSharp.OrderNM;

namespace DesignPatternsCSharp.TaxService
{
    public class USTaxService : ITaxServiceStrategy
    {
        public decimal calculateTax(IOrder order)
        {
            decimal totalTax = 0.0m;
            decimal taxPercent = 0.0m;

            switch (order.destination)
            {
                case "CA":
                    taxPercent = 7.25m;
                    break;
                case "WA":
                    taxPercent = 10.0m;
                    break;
                case "MA":
                    taxPercent = 5.6m;
                    break;
                default:
                    taxPercent = 0.0m;
                    break;
            }

            foreach (IItem item in order.items)
            {
                totalTax += (item.value * taxPercent) / 100;
            }

            return totalTax;
        }
    }
}