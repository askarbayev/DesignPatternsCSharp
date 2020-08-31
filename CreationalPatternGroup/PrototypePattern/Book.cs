namespace DesignPatternsCSharp.PrototypePattern
{
    public class Book : Item
    {

        public string Author;
        public Book(string title, decimal price, string url, string author) : base(title, price, url)
        {
            this.Author = author;
        }
    }


}