using TemplateMethodPattern.Abstractions;

namespace TemplateMethodPattern.Implementations
{
    public class PdfDocument : Document
    {
        protected override void AddBody()
        {
            Console.WriteLine("PDF: Body content added.");
        }

        protected override void Save()
        {
            Console.WriteLine("PDF: Document saved as a PDF file.");
        }
    }
}
