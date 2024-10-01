using IteratorPattern.Abstractions;
using System.Collections.Generic;

namespace IteratorPattern.Implementations
{
    public class BookCollection : IAggregate<Book>
    {
        private readonly List<Book> _books = new List<Book>();

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public IIterator<Book> CreateIterator()
        {
            return new BookIterator(_books);
        }
    }
}
