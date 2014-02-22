using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Collections;

namespace GenericLib
{
    public class OperationTimer: IDisposable
    {
        private Int64 _startTime;
        private string _text;
        private int _collectionCount;
        public OperationTimer(string text)
        {
            PrepareForOperation();
            _text = text;
            _collectionCount = GC.CollectionCount(0);
            _startTime = Stopwatch.GetTimestamp();
        }

        #region IDisposable 成员

        public void Dispose()
        {
            Console.WriteLine("{0,6:###.00} 秒 (GCs={1,3}) {2}",
                (Stopwatch.GetTimestamp() - _startTime) / (Double)Stopwatch.Frequency,
                GC.CollectionCount(0) - _collectionCount, 
                _text);
        }

        #endregion

        private static void PrepareForOperation()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }

    public static class GenericAdvantage
    {
        public static void ValueTypePerfTest()
        {
            const int count = 16000000;
            using (new OperationTimer("List<Int32>"))
            {
                List<int> l = new List<int>();
                for (int n = 0; n < count; n++)
                {
                    l.Add(n);
                    int x = l[n];
                }
                l = null;
            }

            using (new OperationTimer("ArryList of Int32"))
            {
                ArrayList l = new ArrayList();
                for (int n = 0; n < count; n++)
                {
                    l.Add(n);          // boxing: Spend much performance.
                    int x = (int)l[n]; // Unboxing: hard to read and type unsafe.
                }
                l = null;
            }
        }

        public static void ReferenceTypePerfTest()
        {
            const int count = 16000000;
            using (new OperationTimer("List<string>"))
            {
                List<string> l = new List<string>();
                for (int n = 0; n < count; n++)
                {
                    l.Add("X");
                    string x = l[n];
                }
                l = null;
            }

            using (new OperationTimer("ArryList of X"))
            {
                ArrayList l = new ArrayList();
                for (int n = 0; n < count; n++)
                {
                    l.Add("X");          // boxing
                    string x = (string)l[n]; // Unboxing: spend performance and hard to read;
                }
                l = null;
            }
        }
    }
}
