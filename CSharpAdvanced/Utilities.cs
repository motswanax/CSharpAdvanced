using System;

namespace CSharpAdvanced
{
    /*
     where T : IComparable
    where T : Product
    where T : struct
    where T : class
    whre T : new()
     */
    public class Utilities
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        /* Generic method inside a non-generic class. Redoing Max using generics. Uses where constraint */
        public T Max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
