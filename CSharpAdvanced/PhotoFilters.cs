using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvanced
{
    public class PhotoFilters
    {
        internal void ApplyBrightness(object photo)
        {
            Console.WriteLine("Apply brightness");
        }

        internal void ApplyContrast(object photo)
        {
            Console.WriteLine("Apply contrast");
        }

        internal void Resize(object photo)
        {
            Console.WriteLine("Resize photo");
        }
    }
}
