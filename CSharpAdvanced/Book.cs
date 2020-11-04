namespace CSharpAdvanced
{
    public class Book : Product
    {
        public string Isbn { get; set; }

        public Book()
        {

        }

        public Book(string Isbn, string Title)
        {
            this.Isbn = Isbn;
            this.Title = Title;
        }
    }
}