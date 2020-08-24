using OrderNM;
using System;
using System.IO;

namespace InvoiceService
{
    public class FileInvoiceServiceStrategy : InvoiceServiceStrategy
    {
        public override void Generate(IOrder order)
        {
            using (var stream = new StreamWriter($"Invoice_{Guid.NewGuid()}.txt"))
            {
                stream.Write(GenerateStringInvoice(order));
                stream.Flush();
            }
        }
    }
}