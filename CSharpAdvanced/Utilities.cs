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
    public class Utilities<T> where T : IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }

        /* Generic method inside a non-generic class. Redoing Max using generics. Uses where constraint */
        public T Max(T a, T b) 
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
