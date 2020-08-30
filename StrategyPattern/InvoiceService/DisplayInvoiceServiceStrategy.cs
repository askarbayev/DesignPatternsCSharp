using DesignPatternsCSharp.OrderNM;
using System;

namespace DesignPatternsCSharp.InvoiceService
{
    public class DisplayInvoiceServiceStrategy : InvoiceServiceStrategy
    {
        public override void Generate(IOrder order)
        {
            Console.WriteLine(GenerateStringInvoice(order));
        }
    }
}