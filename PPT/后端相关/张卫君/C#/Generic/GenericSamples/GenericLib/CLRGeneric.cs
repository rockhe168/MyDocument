using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace GenericLib
{
    public class CLRGeneric
    {
        private IList<int> _ilstInt;
        private ICollection<int> _iclInt;
        private IEnumerable<int> _ienumInt;
        private IDictionary<int, string> _idicInt;

        private List<int> _lstInt;
        private Comparer<int> _comInt;
        private Dictionary<int, string> dicInt;

        private Action<int> _act;
        private Predicate<int> _pre;
        private Func<int, string> _func;

        private void GenericMethod()
        {
            int[] arr = new int[1];
          //  Array.Exists<int>(arr, c => true);
            Array.Sort<int>(arr);
            Array.BinarySearch(arr, 1);
            
        }
    }
}
