using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericLib
{
    public class DictionaryStringKey<TValue>: Dictionary<string, TValue>
    {
    }

    public class DictionaryStringKeyValue : Dictionary<string, string>
    { 
    }

    public static class OpenCloseGenericClass
    {
        public static void Test()
        {
            Type t = null;
            t = typeof(Dictionary<,>);
            CreateInstance(t);
            t = typeof(DictionaryStringKey<>);
            CreateInstance(t);
            t = typeof(DictionaryStringKeyValue);
            CreateInstance(t);
        }

        private static object CreateInstance(Type t)
        {
            object o = null;
            try
            {
                o = Activator.CreateInstance(t);
                Console.WriteLine("以创建 {0} 的实例", t.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return o;
        }
    }
}
