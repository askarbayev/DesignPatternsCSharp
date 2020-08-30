namespace PrototypePattern
{
    public class Movie : Item
    {

        public string Genre;
        public Movie(string title, decimal price, string url, string genre) : base(title, price, url)
        {
            this.Genre = genre;
        }
    }
}