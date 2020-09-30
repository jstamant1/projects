using System;

namespace Dynamic
{
    public class MyObject
    {
        public string Value { get; set; }
    }

    class Program
    {
        //There are two types of programming languages: 
        //  Dynamically-typed: C#, Java             -> type resolution is done at compile-time
        //      Since .NET 4 some dynamic capabilities have been added  
        //  Statically-typed: Javascript, Python    -> type resolution is done at run-time
        //
        //If we're not using dynamic, we must use reflection
        static void Main(string[] args)
        {
            var obj = new MyObject();
            obj.Value = "<My Name>";

            //example using reflection 
            object reflection = obj;
            var propertyInfo = reflection.GetType().GetProperty("Name")?.GetValue(reflection, null);
            Console.WriteLine(propertyInfo);

            //exemple using dynamic
            dynamic dynamicObject = new MyObject();
            dynamicObject.Value = "<My Value>";
            Console.WriteLine(dynamicObject.Value);

            //It work in a similar way to Javascript (let)
            //Notice the Type changing from dynamic {string} to dynamic {int}
            dynamicObject.Value = 2;
            dynamicObject.Value = 'a';

            //However we must be careful when using dynamic types,
            //In this case, the application will crash but Visual Studio won't see this as an error 
            //This is why when using dynamic types it is important to have good unit tests
            try
            {
                dynamicObject.Value = "<string>";
                dynamicObject.Value++;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Implicit conversions are also used


            Console.ReadLine();
        }
    }
}
