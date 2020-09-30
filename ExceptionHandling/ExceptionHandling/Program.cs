using System;
using System.IO;

namespace ExceptionHandling
{
    class CustomException : Exception
    {
        public CustomException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }

    class Program
    {
        const string fileLocation = @"../../../finally-example.txt";
        //Should always have a exception handling block
        //There are different ways for different applications
        static void Main(string[] args)
        {
            int value = 999;
            StreamReader streamReader = null;

            try
            {
                streamReader = new StreamReader(fileLocation);
                var content = streamReader.ReadToEnd();
                Console.WriteLine(content);

                int quotient = value / 0;
                int product = value * 1000000000;

                throw new SystemException();
            }
            //Exception is the parent of every exception in .NET    
            //  ex: DivideByZeroException : ArithmeticException, 
            //      ArithmeticException : SystemException,
            //      SystemException : Exception
            //
            //Can use multiple catch to catch different exceptions (must be more and more specific) 
            catch (DivideByZeroException) {
                Console.WriteLine("DivideByZeroException");
            }
            catch (ArithmeticException) 
            {
                //...
            }
            catch (SystemException) 
            {
                Console.WriteLine("SystemException has been thrown");
            }
            //We can use an argument to be able to access the exception
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //An exception inside an exception
                Console.WriteLine(ex.InnerException);
            }
            //some classes in .NET use unmanaged ressources (ressources that are not managed by CLR, there's no garbage collection that is applied to them)
            //  ex: file handles, database connections, network connections, graphic handles
            //
            //In this case, we need to manually do the clean up. Those classes are expected to implement the IDisposable interface (IDisposable { void Dispose(); })
            //
            //The finally block will always be executed
            finally
            {
                //If anything goes wrong, we want to make sure to close the StreamReader
                //If we don't close it, we're going to keep files open on the disk or network/database connections and you might run out of ressources 
                streamReader?.Dispose();
                Console.WriteLine("Clean up");
            }

            //A cleaner way to do the clean up would be with a "using"
            try
            {
                //in this case, the "finally" block is automatically generated
                using (var streamReader2 = new StreamReader(fileLocation))
                {
                    var content = streamReader.ReadToEnd();
                }
            }
            catch(Exception ex)
            {
                //example for a custom exception
                throw new CustomException("<Your exception message here>", ex);
            }
            


                Console.ReadLine();
        }
    }
}
