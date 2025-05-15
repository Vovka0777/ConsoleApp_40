using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41_1
{
    class SortBooks
    {
        List<Book> books = new List<Book>();

        internal List<Book> Books { get => books; set => books = value; }

        public SortBooks(List<Book> books) { this.Books = books; }

        public void SortB(SortBooks comparer)
        {
            Array.Sort(books,comparer);
        }
    }
}
