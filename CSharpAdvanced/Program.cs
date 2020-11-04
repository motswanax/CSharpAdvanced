using System;
using System.Reflection;

namespace CSharpAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("1111", "C# Advanced");

            var numbers = new GenericList<Book>();
            numbers.Add(new Book());


            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234", new Book());
        }
    }
}
