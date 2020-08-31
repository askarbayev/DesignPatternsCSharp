namespace DesignPatternsCSharp.FactoryPattern
{
    public class Blog : Website
    {
        public override void CreatePages()
        {
            Pages.Add(new MainPage());
            Pages.Add(new CommentPage());
            Pages.Add(new ProfilePage());
        }
    }
}