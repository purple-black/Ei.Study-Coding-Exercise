namespace TemplateMethodPattern.Abstractions
{
    public abstract class Document
    {
        public void CreateDocument()
        {
            AddHeader();
            AddBody();
            AddFooter();
            Save();
        }

        protected virtual void AddHeader()
        {
            Console.WriteLine("Header added to the document.");
        }

        protected abstract void AddBody();

        protected virtual void AddFooter()
        {
            Console.WriteLine("Footer added to the document.");
        }

        protected abstract void Save();
    }
}
