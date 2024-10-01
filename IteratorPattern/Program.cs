// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*
A scenario where we have a collection of books. Each book has a title and an author,
and we want to traverse this collection in a specific order (like alphabetically by title).
The goal is to create a custom iterator for our BookCollection so that we can traverse it without
exposing its internal structure directly.
*/

using IteratorPattern.Abstractions;
using IteratorPattern.Implementations;
using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BookCollection bookCollection = new BookCollection();
            bookCollection.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald"));
            bookCollection.AddBook(new Book("1984", "George Orwell"));
            bookCollection.AddBook(new Book("To Kill a Mockingbird", "Harper Lee"));
            
            IIterator<Book> iterator = bookCollection.CreateIterator();

            Console.WriteLine("Iterating through the book collection:\n");

            while (iterator.MoveNext())
            {
                Console.WriteLine(iterator.Current.ToString());
            }

            iterator.Reset();
            Console.WriteLine("\nAfter resetting the iterator:");

            while (iterator.MoveNext())
            {
                Console.WriteLine(iterator.Current.ToString());
            }

            Console.ReadLine();
        }
    }
}

