using System;

namespace DesignPatternsCSharp.PrototypePattern
{
    /// <summary>
    /// The class used to create an object with prototype pattern. 
    /// Clone method is used to clone the object instead of creating a new one which might be costly.
    /// </summary>
    public class Item : ICloneable
    {
        public string Title;
        public decimal Price;
        public string Url;
        public History History;
        public Item(string title, decimal price, string url)
        {
            this.Title = title;
            this.Price = price;
            this.Url = url;
            this.History = new History("histoty text");
        }

        public object Clone()
        {
            // shallow copy
            return (Item)this.MemberwiseClone();
        }

        public object DeepClone()
        {
            // deep copy
            Item item = (Item)this.MemberwiseClone();
            item.History = new History(item.History.text);
            return item;
        }

    }

    public class History
    {
        public string text;
        public History(string text)
        {
            this.text = text;
        }
    }
}