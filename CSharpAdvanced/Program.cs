using System;

namespace CSharpAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var photoProcessor = new PhotoProcessor();
            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            photoProcessor.Process("photo.jpg", filterHandler);
        }

        // Adding new filter/functionality that didn't come with the program.
        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply remove red eye. ");
        }
    }
}
