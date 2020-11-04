using System;

namespace CSharpAdvanced
{
    public class BookList
    {
        public void Add(Book book)
        {
            throw new NotImplementedException();
        }

        public Book this[int index] { get { throw new NotImplementedException(); } }
    }

    public class ObjectList
    {
        public void Add(object value)
        {
            throw new NotImplementedException();
        }

        public object this[int index] { get { throw new NotImplementedException(); } }
    }
}
