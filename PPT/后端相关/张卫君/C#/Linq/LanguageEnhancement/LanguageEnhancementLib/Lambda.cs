using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace LanguageEnhancement
{
    public class Lambda
    {
        public static void DisplayProcesses()
        {
            List<ProcessData> processes = new List<ProcessData>();
            foreach (Process process in Process.GetProcesses())
            {
                // 筛选条件
                if (process.WorkingSet64 >= 20 * 1024 * 1024)
                {
                    processes.Add(new ProcessData
                    {
                        Id = process.Id,
                        Name = process.ProcessName,
                        Memory = process.WorkingSet64
                    });
                }
            }
            // Print out the list of processes to the console
        }

        public static void DisplayProcesses(Predicate<Process> match)
        {
            List<ProcessData> processes = new List<ProcessData>();
            foreach (Process process in Process.GetProcesses())
            {
                if (match(process)) // 筛选条件
                {
                    processes.Add(new ProcessData
                    {
                        Id = process.Id,
                        Name = process.ProcessName,
                        Memory = process.WorkingSet64
                    });
                }
            }
            // Print out the list of processes to the console
        }

        public static bool Filter(Process process)
        {
            return process.WorkingSet64 > 20 * 1024 * 1024;
        }

        public static void CallWithDelegate()
        {
            DisplayProcesses(Filter);
        }

        public static void CallWithAnonymousMethod()
        {
            DisplayProcesses(delegate(Process process)
            {
                return process.WorkingSet64 > 20 * 1024 * 1024;
            });
        }

        public static void CallWithLambdaExpression()
        {
            DisplayProcesses(p => p.WorkingSet64 > 20 * 1024 * 1024);
        }

        public static void DeclareDelegateFromLambda()
        {
            // lambda 表达式不包含参数
            Func<DateTime> getDateTime = () => DateTime.Now;

            // lambda 表达式: 包含隐式类型的参数
            Action<string> printImplicit = s => Console.WriteLine(s);

            // lambda 表达式: 包含显式类型的参数
            Action<string> printExplicit = (string s) => Console.WriteLine(s);

            // lambda 表达式: 包含2个隐式类型的参数
            Func<int, int, int> sumInts = (x, y) => x + y;

            // Predicate<T> 和 Func<T, Boolean> 是等价的 (但是不兼容)
            Predicate<int> equalsOne1 = x => x == 1;
            Func<int, bool> equalsOne2 = x => x == 1;

            // Lambda表达式包含表达式体.
            Func<int, int> incInt = x => x + 1;
            Func<int, double> incIntAsDouble = x => x + 1;

            // Lambda表达式包含显式类型参数以及代码体.
            Func<int, int, int> comparer = (int x, int y) =>
            {
                if (x > y) return 1;
                if (x < y) return -1;
                return 0;
            };
        }
    }
}
