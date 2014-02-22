using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace GenericLib
{
    public class SecondaryConstraintOfInterface<T>
        where T: IComparable, IList
    {
        public void M()
        {
            Object o = null;
            T test = default(T);
            test.CompareTo(o);
            test.Clear();
        }
    }

    public class SecondaryConstraintOfType
    {
        public static List<TBase> ConvertList<T, TBase>(IList<T> list)
            where T: TBase
        {
            List<TBase> lstBase = new List<TBase>(list.Count);
            foreach (T t in list)
            {
                lstBase.Add(t);
            }
            return lstBase;
        }

        public static void TestConvertList()
        {
            List<string> ls = new List<string>();
            IList<object> lo = ConvertList<string, object>(ls);
            IList<IComparable> lc = ConvertList<string, IComparable>(ls);
            IList<IComparable<string>> lcs = ConvertList<string, IComparable<string>>(ls);
            //IList<Exception> le = ConvertList<string, Exception>(ls); // compile error.
        }
    }
}
