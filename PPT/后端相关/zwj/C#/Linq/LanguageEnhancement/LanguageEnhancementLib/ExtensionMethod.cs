using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LanguageEnhancement
{
    public static class ExtensionMethodCaller
    {
        public static void GetTotalMemoryByStatic()
        {
            List<ProcessData> processes = new List<ProcessData>();
            Console.WriteLine("Total memory: {0} MB",
                StaticMethod.TotalMemory(processes) / 1024 / 1024);
        }

        public static void GetTotalMemoryByExtension()
        {
            List<ProcessData> processes = new List<ProcessData>();
            Console.WriteLine("Total memory: {0} MB",
                processes.TotalMemory() / 1024 / 1024);
        }
    }

    public static class ExtensionMethod
    {
        public static Int64 TotalMemory(this IEnumerable<ProcessData> processes)
        {
            Int64 result = 0;
            foreach (var process in processes)
                result += process.Memory;
            return result;
        }
    }

    public static class StaticMethod
    {
        public static Int64 TotalMemory(IEnumerable<ProcessData> processes)
        {
            Int64 result = 0;
            foreach (var process in processes)
                result += process.Memory;
            return result;
        }
    }
}
