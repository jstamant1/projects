using System;

namespace Delegates
{
    class Program
    {
        //Is an object that know how to call a method or a group of methods
        //A reference to a function

        //Use delegates to create applications that are extensible and flexible, often used in frameworks

        //What the client would do without delegates
        static void ClientnoDelegate()
        {
            ImageProcessor imageProcessor = new ImageProcessor();

            imageProcessor.ApplyFiltersWithoutDelegate("C:\\img.jpg");
        }

        static void ClientWithDelegate()
        {
            ImageProcessor imageProcessor = new ImageProcessor();
            ImageFilters imageFilters = new ImageFilters();

            ImageProcessor.ImageFilterHandler filterHandler = imageFilters.ApplyBrightnessFilter;

            //To add another filter
            filterHandler += imageFilters.ApplyContrastFilter;

            //Add created filter
            filterHandler += ApplyRedEyeFilter;

            imageProcessor.ApplyFiltersWithDelegate("C:\\img.jpg", filterHandler);
        }

        //To create a filter that doesn't exist in the framework:
        static void ApplyRedEyeFilter(Image image)
        {
            Console.WriteLine("ApplyRedEyeFilter to {0}", image.Name);
        }

        static void Main(string[] args)
        {
            //ClientnoDelegate();
            ClientWithDelegate();
        }
    }
}
