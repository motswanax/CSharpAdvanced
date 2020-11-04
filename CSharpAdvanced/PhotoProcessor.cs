using System;

namespace CSharpAdvanced
{
    public class PhotoProcessor
    {
        // Delegate allows program to be extensible.
        public delegate void PhotoFilterHandler(Photo photo);

        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            // System.Action<>
            // System.Func<>

            var photo = Photo.Load(path);

            var filters = new PhotoFilters();
            /*filters.ApplyBrightness(photo);
            filters.ApplyContrast(photo);
            filters.Resize(photo);*/
            filterHandler(photo);

            photo.Save();
        }
    }
}
