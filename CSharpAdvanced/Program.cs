using System;

namespace CSharpAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is a very long blog post... yada yada yada";
            var shortenedPost = post.Shorten(5);

            Console.WriteLine(shortenedPost);
        }
    }
}
