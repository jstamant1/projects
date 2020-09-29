using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            NormalObj normalObj = new NormalObj { Id=1, Description="A"};

            //Need 2 seperate lists
            var numbers = new List<int>();
            numbers.Add(10);

            var normalList = new NormalList();
            normalList.Add(normalObj);

            //Can use one generic list
            //Reusable, No performance penality
            var genericListInt = new GenericList<int>();
            genericListInt.Add(10);

            var genericListNormalObj = new GenericList<NormalObj>();
            genericListNormalObj.Add(normalObj);

            //.NET already has generic collections so there's no need to create our own
            //see System.Collections.Generic            
            ICollection<int> A = new List<int>();
            IEnumerable<int> B = new List<int>();
            IList<int> C = new List<int>();
            //etc

            //Can also make generic objects
            //Also called generic dictionnaries
            GenericObj<int, int, string> intInt = new GenericObj<int, int, string> { Id = 1, Description = 1 };
            GenericObj<int, string, string> intString = new GenericObj<int, string, string> { Id = 1, Description = "Description" };

            //Value type example
            var valueType = new ValueTypeConstraint<int>(1);
            var valueTypeNull = new ValueTypeConstraint<int>();

            Console.WriteLine(valueType.GetValueOrDefault().ToString());
            Console.WriteLine(valueTypeNull.GetValueOrDefault().ToString());
        }
    }

    public class NormalList
    {
        public void Add(NormalObj value)
        {
            throw new NotImplementedException();
        } 

        public NormalList this[NormalList index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class GenericList<T>
    {
        public void Add(T value)
        {

        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
