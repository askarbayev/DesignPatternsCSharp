namespace FactoryPattern
{
    public class Shop : Website
    {
        public override void CreatePages()
        {
            Pages.Add(new MainPage());
            Pages.Add(new CartPage());
            Pages.Add(new ProfilePage());
            Pages.Add(new ProductPage());
        }
    }
}