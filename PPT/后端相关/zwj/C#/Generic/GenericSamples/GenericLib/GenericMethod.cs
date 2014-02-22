using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericLib
{
    public class GenericMethod<T>
    {
        public TOutput Converter<TOutput>(T input)
        {
            TOutput result = (TOutput)Convert.ChangeType(input, typeof(TOutput));
            return result;
        }

        public static void swap<T>(ref T o1, ref T o2)
        {
            T temp = o1;
            o1 = o2;
            o2 = temp;
        }

        public static void CallingSwap()
        {
            int n1 = 1;
            int n2 = 2;
            Console.WriteLine("n1 = {0}, n2 = {1}", n1, n2);
            swap<int>(ref n1, ref n2);
            Console.WriteLine("n1 = {0}, n2 = {1}", n1, n2);

            string s1 = "Aidan";
            string s2 = "Kristin";
            Console.WriteLine("s1 = {0}, s2 = {1}", s1, s2);
            swap<string>(ref s1, ref s2);
            Console.WriteLine("s1 = {0}, s2 = {1}", s1, s2);

            Console.WriteLine("n1 = {0}, n2 = {1}", n1, n2);
            swap(ref n1, ref n2);
            Console.WriteLine("n1 = {0}, n2 = {1}", n1, n2);

            
        }
    }
}
