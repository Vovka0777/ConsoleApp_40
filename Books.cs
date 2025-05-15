using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41_1
{
    class Book
    {
        string name;
        string author;
        string pubhouse;
        //List<Book> books = new List<Book>();

        public string Name { get => name; set => name = value; }
        public string Author { get => author; set => author = value; }
        public string Pubhouse { get => pubhouse; set => pubhouse = value; }
        //List<Book> Books { get => books; set => books = value; }

        public Book(string name, string author, string pubhouse /*List<Book> books*/)
        {
            this.Name = name;
            this.Author = author;
            this.Pubhouse = pubhouse;
            //this.books = books;
        }

        public void AddBook ()
        {
            Console.WriteLine("Введите название");
            string name = Console.ReadLine();
            Console.WriteLine("Введите автора");
            string author = Console.ReadLine();
            Console.WriteLine("Введите издательство");
            string pubhouse = Console.ReadLine();
            books.Add (new Book(name, author, pubhouse));
        }

        //static void SortBooks (Book Books)
        //{
        //    Array.Sort(Book Books);
        //}
    }
}
