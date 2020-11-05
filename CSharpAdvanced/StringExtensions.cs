using System;
using System.Linq;

namespace CSharpAdvanced
{
    public static class StringExtensions
    {
        /* Note to self: Use extension methods only when you absolutely have to! */
        // Typical extension method signature.
        public static string Shorten(this string str, int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException("Number of words should be greater than or equal to zero. ");
            if (numberOfWords == 0)
                return "";

            var words = str.Split(' ');

            if (words.Length <= numberOfWords)
                return str;

            return string.Join(" ", words.Take(numberOfWords)) + "... ";
        }
    }
}
