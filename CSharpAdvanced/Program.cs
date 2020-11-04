using System;

namespace CSharpAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            // args => expression
            // number => number * number;
            // () => ... [no arguments]
            // x => ... [one argument]
            // (x, y, z) => ... [multiple arguments]
            Func<int, int> square = number => number * number;
            Console.WriteLine(square(5));

            const int factor = 5;
            Func<int, int> multiplier = n => n * factor;
            var result = multiplier(10);
            Console.WriteLine(result);
        }

        // Method without lambdas
        static int Square(int number)
        {
            return number * number;
        }
    }
}
