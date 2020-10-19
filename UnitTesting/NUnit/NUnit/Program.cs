using System;

namespace NUnit
{
    class Program
    //Two Types of methods:
    //  Query methods:      returns a value.
    //  Command methods:    performs an action, make a change in the system.
    //
    //Should not test language feature or third-party frameworks (ex: EF)
    //
    //For the organization:
    //  Each project must have their own test project with the same name with "Tests" at the end (ex: Reservation => ReservationTests) 
    //  Integration tests must be seperated from unit tests because integration tests take longer to execute
    //  
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
