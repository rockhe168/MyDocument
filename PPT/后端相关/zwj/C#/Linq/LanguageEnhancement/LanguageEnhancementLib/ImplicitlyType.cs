using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LanguageEnhancement
{
    public class ImplicitlyType
    {
        public static void ExplicitlyTypeVariable()
        {
            int i = 12;
            string s = "Hello";
            double d = 1.0;
            int[] numbers = new int[] { 1, 2, 3 };
            object o = new object();
            Dictionary<int, string> dic = new Dictionary<int, string>();
        }

        public static void ImplicitlyTypeVariable()
        {
            var i = 12;
            var s = "Hello";
            var d = 1.0;
            var numbers = new int[] { 1, 2, 3 };
            var o = new object();
            var dic = new Dictionary<int, string>();
        }
    }
}
