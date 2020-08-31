namespace FactoryPattern
{
    public class WebsiteFactory
    {
        public static Website GetWebsite(WebsiteType type)
        {
            switch (type)
            {
                case WebsiteType.BLOG:
                    return new Blog();
                case WebsiteType.SHOP:
                    return new Shop();
                default:
                    return null;
            }
        }
    }
}