using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("write the book Tittle:");
            string Tittle = Console.ReadLine();
            Console.Write("write the book author:");
            string Author = Console.ReadLine();
            Console.Write("write the book Content:");
            string Content = Console.ReadLine();
            Book Jogan = new Book(Tittle, Author, Content);
            Jogan.Show();
            Console.ReadKey();
        }
        class Book
        {
            private Tittle bookTitle;
            private Author bookAuthor;
            private Content bookContent;

            public Book(string title, string author, string content)
            {
                bookTitle = new Tittle(title);
                bookAuthor = new Author(author);
                bookContent = new Content(content);
            }

            public void SetTitle(string title)
            {
                bookTitle = new Tittle(title);
            }

            public void SetAuthor(string author)
            {
                bookAuthor = new Author(author);
            }

            public void SetContent(string content)
            {
                bookContent = new Content(content);
            }

            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                bookTitle.Show();
                Console.ForegroundColor = ConsoleColor.Green;
                bookAuthor.Show();
                Console.ForegroundColor = ConsoleColor.Blue;
                bookContent.Show();
                Console.ResetColor();
            }
        }
        class Tittle
        {
            public string Tittl { get; set; }
            public void Show()
            {
                Console.WriteLine("Book name:" + Tittl);
            }
            public Tittle(string Tittle)
            {
                Tittl = Tittle;
            }
        }
        class Author
        {
            public string Autho { get; set; }
            public void Show()
            {
                Console.WriteLine("Author name:" + Autho);
            }
            public Author(string Author)
            {
                Autho = Author;
            }
        }
        class Content
        {
            public string Cont { get; set; }
            public void Show()
            {
                Console.WriteLine("Book name:" + Cont);
            }
            public Content(string Content)
            {
                Cont = Content;
            }
        }
    }
}
