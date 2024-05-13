using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{

    public enum Genre
    { 
        Fiction,
        NonFiction,
        Mystery,
        ScienceFiction,
        Fantasy,
        Romance,
        Biography,
        History,
        SelfHelp,
        Poetry,
        Thriller,
        Horror,
        Comedy,
        Drama,
        Adventure,
        Children,
        YoungAdult,
        Science,
        Philosophy,
        Religion,
    }
    
    public class Book
    {
        public string FullName { get; set; }
        public string Title { get; set; }
        public string BookName { get; set; }
        public int ReleaseYear { get; set; }
        public int ISBN { get; set; }
        public Genre genre { get; set; }
        public Book(string fullName, string title, string bookName, int releaseYear, int isbn, Genre genre1)
        {
            FullName = fullName;
            Title = title;
            BookName = bookName;
            ReleaseYear = releaseYear;
            ISBN = isbn;
            genre = genre1;
        }

        public override string ToString()
        {
            return $"Author: {FullName}, Title: {Title}, BookName: {BookName}, ReleaseYear: {ReleaseYear}, ISBN: {ISBN}, Genre: {genre}";
        }

    }
}
