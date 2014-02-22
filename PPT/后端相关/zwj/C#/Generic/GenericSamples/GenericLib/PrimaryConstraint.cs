using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace GenericLib
{
    public class PrimaryConstraintOfStream<T> 
        where T: Stream
    {
        public void CloseStream(T stream)
        {
            stream.Close();
        }
    }

    public class PrimaryConstraintOfClass<T>
        where T : class
    {
        public void M()
        {
            T temp = null;
        }
    }

    public class PrimaryConstraintOfStruct<T>
        where T : struct
    {
        public void M()
        {
            T t = new T();
        }
    }
}
