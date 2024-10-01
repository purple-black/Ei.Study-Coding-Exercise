using TemplateMethodPattern.Abstractions;

namespace TemplateMethodPattern.Implementations
{
    public class WordDocument : Document
    {
        protected override void AddBody()
        {
            Console.WriteLine("Word: Body content added.");
        }

        protected override void Save()
        {
            Console.WriteLine("Word: Document saved as a Word file.");
        }
    }
}
