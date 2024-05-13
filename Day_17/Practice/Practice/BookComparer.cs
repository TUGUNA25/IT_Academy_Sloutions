using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{

    public class BookNameComparer : IComparer<Book>
    {
        public int Compare(Book? x, Book? y)
        {
            return x.BookName.CompareTo(y.BookName);
        }
    }

    public class ReleaseYearComparer : IComparer<Book>
    {
        public int Compare(Book? x, Book? y)
        {
            return y.ReleaseYear.CompareTo(x.ReleaseYear);
        }
    }

    public class ISBNComparer : IComparer<Book>
    {
        public int Compare(Book? x, Book? y)
        {
            return x.ISBN.CompareTo(y.ISBN);
        }
    }

    public class GenreComparer : IComparer<Book>
    {
        public int Compare(Book? x, Book? y)
        {
            return x.genre.CompareTo(y.genre);
        }
    }
}
