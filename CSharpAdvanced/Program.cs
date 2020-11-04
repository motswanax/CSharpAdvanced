using System;

namespace CSharpAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // lambda operator.
            var cheapBooks = books.FindAll(b => b.Price < 10);

            foreach (Book book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}
