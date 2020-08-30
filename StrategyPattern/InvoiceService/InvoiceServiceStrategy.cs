using DesignPatternsCSharp.OrderNM;

namespace DesignPatternsCSharp.InvoiceService
{
    public abstract class InvoiceServiceStrategy : IInvoiceServiceStrategy
    {
        public abstract void Generate(IOrder order);

        public string GenerateStringInvoice(IOrder order)
        {
            string invoice = "ORDER ITEMS INVOICE:";
            decimal totalValue = 0m;

            foreach (var item in order.items)
            {
                totalValue += item.value;
                invoice += $"\n Name: {item.name}";
                invoice += $"\n     Value: {item.value}";
            }

            invoice += $"\n VALUE: {totalValue}";
            invoice += $"\n TAX: {order.getTax()}";
            invoice += $"\n TOTAL VALUE: {totalValue + order.getTax()}";

            return invoice;
        }
    }
}