using OrderNM;
using System;

namespace InvoiceService
{
    public class DisplayInvoiceServiceStrategy : InvoiceServiceStrategy
    {
        public override void Generate(IOrder order)
        {
            Console.WriteLine(GenerateStringInvoice(order));
        }
    }
}