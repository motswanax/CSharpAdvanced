using System;

namespace CSharpAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            var cheapBooks = books.FindAll(IsCheaperThan10Dollars);

            foreach (Book book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }

        // Predicate example
        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
    }
}
