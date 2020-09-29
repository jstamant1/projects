using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    //Usually T followed by a proper name
    //ex: GenericObj<T, U, V> would not be acceptable
    public class GenericObj<TKey, TDesc, TVal>
    {
        public TKey Id { get; set; }
        public TDesc Description { get; set; }

        public TVal A { get; set; }
        public TVal B { get; set; }

        //How to usually compare two integers:
        public int Max(int val1, int val2)
        {
            return val1 > val2 ? val1 : val2;
        }

        //How to compare generic types with contraints
        //Constraints can also be used at the class level 
        //ex: public class GenericObj<TKey, TDesc, TVal, T> where T : IComparable { }
        //You don't have to be inside a generic class

        //There are 5 types of contraints: 
        //  where T : Interface                             ex: IComparable
        //  where T : Class                                 ex: NormalObj
        //  where T : class                                 ex: class
        //  where T : Value Type                            ex: int
        //  where T : Object with a default constructor     ex: new()
        
        //Example for an Interface:
        public T Max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
