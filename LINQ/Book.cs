namespace LINQ
{
    public class Book
    {
        private string title;
        private float price;

        public string Title { get; set; }
        public float Price { get; set; }

        public Book()
        {
        }

        public Book(string title, float price)
        {
            Title = title;
            Price = price;
        }
    }
}
