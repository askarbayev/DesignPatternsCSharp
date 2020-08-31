using System.Collections.Generic;
namespace DesignPatternsCSharp.FactoryPattern
{

    /// <summary>
    /// This is a Creator class which has an abstract factory method.
    /// Subclasses of this class will implement the factory method.
    /// </summary>
    public abstract class Website
    {
        public List<Page> Pages = new List<Page>();

        public Website()
        {
            CreatePages();
        }
        public abstract void CreatePages();

        public List<Page> GetPages()
        {
            return this.Pages;
        }
    }
}