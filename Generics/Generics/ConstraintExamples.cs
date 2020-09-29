using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    //Example for a class
    public class ClassConstraint<TNormalObj> where TNormalObj : NormalObj
    {
        public float returnFloat(TNormalObj normalObj)
        {
            return normalObj.Price;
        }

    }

    //Can add multiple constraints 
    public class MultipleConstraint<T> where T : IComparable, new()
    {
        public void DoSomething(T value)
        {
            var obj = new T();
        }

    }

    //Example for a Value Type
    public class ValueTypeConstraint<T> where T : struct
    {
        private object Value;
        public ValueTypeConstraint()
        {

        }

        public ValueTypeConstraint(T value)
        {
            Value = value;
        }

        public bool HasValue
        {
            get { return Value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)Value;

            return default(T);
        }
    }
}
