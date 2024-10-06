using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskC
{
    public class Book : IComparable<Book>
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }

        public int CompareTo(Book other)
        {
            if (other == null) return 1;
            return string.Compare(this.ISBN, other.ISBN, StringComparison.Ordinal);
        }

        public override string ToString()
        {
            return $"ISBN: {ISBN}, Title: {Title}, Author: {Author}";
        }
    }
}


