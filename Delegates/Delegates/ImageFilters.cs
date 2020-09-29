using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    class ImageFilters
    {
        public void ApplyBrightnessFilter(Image image)
        {
            Console.WriteLine("ApplyBrightnessFilter to {0}", image.Name);
        }
        public void ApplyContrastFilter(Image image)
        {
            Console.WriteLine("ApplyContrastFilter to {0}", image.Name);
        }
        public void ApplyResizeFilter(Image image)
        {
            Console.WriteLine("ApplyResizeFilter to {0}", image.Name);
        }

    }
}
