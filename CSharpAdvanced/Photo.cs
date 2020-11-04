using System;

namespace CSharpAdvanced
{
    public class Photo
    {
        public string PhotoPath { get; set; }

        public Photo()
        {

        }

        public Photo(string path)
        {
            PhotoPath = path;
        }

        public static Photo Load(string path)
        {
            return new Photo();
        }

        public void Save()
        {
            Console.WriteLine("Photo saved. ");
        }
    }
}
