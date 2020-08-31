using System;
using DesignPatternsCSharp.TaxService;
using DesignPatternsCSharp.OrderNM;
using DesignPatternsCSharp.InvoiceService;
using DesignPatternsCSharp.ShippingService;
using SingletonPattern;
using BuilderPattern;
using PrototypePattern;
using FactoryPattern;

namespace DesignPatternsCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // strategy pattern test
            //StrategyPatternTest();

            // singleton pattern test
            // SingletonPatternTest();

            // builder pattern test
            //BuilderPatternTest();

            // prototype pattern test
            // PrototypePatternTest();

            // factory pattern test
            FactoryPatternTest();
        }

        static void StrategyPatternTest()
        {
            IOrder order = new Order
            {
                origin = "IL",
                destination = "MA",
                items = new OrderNM.Item[] { new OrderNM.Item { name = "Phone", value = 800.0m }, new OrderNM.Item { name = "TV", value = 500.0m } },
                taxService = new USTaxService(),
                invoiceService = new DisplayInvoiceServiceStrategy(),
                shippingService = new FedExShippingServiceStrategy()
            };

            decimal tax = order.getTax();
            Console.WriteLine(tax);
            order.GenerateInvoice();
            order.ShipOrder();
        }

        static void SingletonPatternTest()
        {
            LoggerSingleton instance = LoggerSingleton.getInstance();
            instance.Write("Fist Instance Sample");
            instance.Log();
            instance.Write("Fist Instance Sample");
            instance.Write("Fist Instance Sample");
            instance.Log();

            LoggerSingleton instanceSecond = LoggerSingleton.getInstance();
            instanceSecond.Write("Second Instance Sample");
            instanceSecond.Log();
        }

        static void BuilderPatternTest()
        {
            LunchOrder.Builder builder = new LunchOrder.Builder();
            builder.AddBread("Taba Nan").AddDressing("Some Dressing").AddMeat("Hourse Meat");
            LunchOrder lunchOrder = new LunchOrder(builder);
            Console.WriteLine(lunchOrder.GetBread());
            Console.WriteLine(lunchOrder.GetDressing());
            Console.WriteLine(lunchOrder.GetMeat());
        }

        static void PrototypePatternTest()
        {
            Register register = new Register();
            Book item = (Book)register.GetItem(ItemType.Book);
            Console.WriteLine(item.History.text);
            Book item2 = (Book)item.DeepClone();
            Console.WriteLine(item2.History.text);
            item2.History.text = "changed history";
            Console.WriteLine(item.History.text);
            Console.WriteLine(item2.History.text);
        }

        static void FactoryPatternTest()
        {
            Blog blog = (Blog)WebsiteFactory.GetWebsite(WebsiteType.BLOG);
            Console.WriteLine(blog.GetPages().Count);
            Shop shop = (Shop)WebsiteFactory.GetWebsite(WebsiteType.SHOP);
            Console.WriteLine(shop.GetPages().Count);
        }

    }
}
