using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericLib
{
    public class StructConstraint<T>
        where T : new()
    {
        public T NewT()
        {
            return new T();
        }

        public TOut NewTout<TOut>()
            where TOut : new()
        {
            return new TOut();
        }
    }
}
