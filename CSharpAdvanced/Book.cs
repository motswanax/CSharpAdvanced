using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvanced
{
    public class Book
    {
        private string title;
        private int price;

        public string Title { get; set; }
        public int Price { get; set; }

        public Book(string Title, int Price)
        {
            Title = title;
            Price = price;
        }

        public Book()
        {
        }
    }
}
