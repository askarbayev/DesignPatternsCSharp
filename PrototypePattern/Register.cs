using System.Collections.Generic;

namespace PrototypePattern
{
    public class Register
    {
        Dictionary<ItemType, Item> items;
        public Register()
        {
            items = new Dictionary<ItemType, Item>();
            LoadItems();
        }
        internal void LoadItems()
        {
            items.Add(ItemType.Book, new Book("Kara Sozder", 200, "url", "Abai"));
            items.Add(ItemType.Movie, new Movie("The pursuit of happines", 50, "url", "Drama"));
        }

        public Item GetItem(ItemType type)
        {
            return items[type];
        }
    }
}