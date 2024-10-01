using IteratorPattern.Abstractions;
using System.Collections.Generic;

namespace IteratorPattern.Implementations
{
    public class BookIterator : IIterator<Book>
    {
        private readonly List<Book> _books;
        private int _currentIndex = -1;

        public BookIterator(List<Book> books)
        {
            _books = books;
        }

        public Book Current => _books[_currentIndex];

        public bool MoveNext()
        {
            if (_currentIndex + 1 < _books.Count)
            {
                _currentIndex++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _currentIndex = -1;
        }
    }
}
