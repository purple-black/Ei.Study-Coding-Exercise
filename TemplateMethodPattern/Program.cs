// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*
A document generation system, consider two types of documents
(e.g.,PDF Document and Word Document) that follow a general structure for creation but differ
in the specific implementation of saving the file or setting up the layout.
The Template Method Pattern can be used to define the overall process of document creation,
while allowing subclasses to customize particular steps.
*/

using TemplateMethodPattern.Implementations;
using TemplateMethodPattern.Abstractions;
using System;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Document pdfDoc = new PdfDocument();
            Console.WriteLine("Creating PDF Document:");
            pdfDoc.CreateDocument();

            Console.WriteLine();

            Document wordDoc = new WordDocument();
            Console.WriteLine("Creating Word Document:");
            wordDoc.CreateDocument();

            Console.ReadLine();
        }
    }
}

