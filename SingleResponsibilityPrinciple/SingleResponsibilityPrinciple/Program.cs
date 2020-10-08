using System;
using System.Collections.Generic;

namespace SingleResponsibilityPrinciple
{
    //Any class should only have one responsbility
    //A good way to know if a certain class has too many responsabilities is by asking yourself "Why would you want to change this class?"
    //  ex: It could be because you want to change to way the products are stored AND to change the persistence if you were to have the Save/Read method
    public class Client
    {
        private readonly HashSet<int> products = new HashSet<int>();
        private static int count = 0;
        public int AddProduct(int productId)
        {
            products.Add(productId);
            return ++count;
        }

        public void RemoveProduct(int productId)
        {
            products.Remove(productId);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, products);
        }

        //Then we could add a method to save the client to a file, then read the client's file etc...
        //However doing this, we're giving too much responsability to the Client class
    }

    public class Persistence
    {
        public void SaveToFile()
        {
            //...
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var myClient = new Client();

            myClient.AddProduct(1);
            myClient.AddProduct(1);
            myClient.AddProduct(2);

            Console.WriteLine(myClient);
            Console.ReadLine();
        }
    }
}
