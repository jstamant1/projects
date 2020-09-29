using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    class ImageProcessor
    {
        //Other developers won't be able to apply a filter that hasn't been defined
        //To make a new filter, he's going to have to decompile and redeploy the code
        //With delegates a developer create his own filter without relying on this code
        public void ApplyFiltersWithoutDelegate(string path)
        {
            var image = Image.Create(path, "img");

            var filters = new ImageFilters();
            filters.ApplyBrightnessFilter(image);
            filters.ApplyContrastFilter(image);
            filters.ApplyResizeFilter(image);

            image.Save();
        }

        //Example of a delegate
        public delegate void ImageFilterHandler(Image image);

        public void ApplyFiltersWithDelegate(string path, ImageFilterHandler filterHandler)
        {
            var image = Image.Create(path, "img");

            filterHandler(image);

            image.Save();
        }
    }
}
