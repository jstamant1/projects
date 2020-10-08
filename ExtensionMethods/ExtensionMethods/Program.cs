using System;

namespace ExtensionMethods
{
    //There is no way to inherit from any type because they're sealed
    //  ex: public class MyClass : String { }

    //The right way to do it would be to create an extension class to add functionalities
    //This class must be static and to follow conventions, the name must start with the name
    //of what it's extending followed by extensionds
    public static class StringExtensions
    {
        //As usual int is the return type and can be any type
        //the type that's extended is the first argument and needs the "this" keyword
        public static int NumberOfWords(this string str)
        {
            return str.Split().Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string myString = "A certain string";

            Console.WriteLine(myString.NumberOfWords());
            Console.ReadLine();
        }
    }
}
