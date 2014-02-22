using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LanguageEnhancement
{
    public class AnonymousType
    {
        public static void MyFirstAnonymousType()
        {
            List<ProcessData> processes = new List<ProcessData>();
            var results = new
            {
                TotalMemory = processes.TotalMemory() / 1024 / 1024,
                Processes = processes
            };
        }

        public static void CompareAnonymousType()
        {
            var v1 = new { Person = "Suzie", Age = 32, CanCode = true };
            var v2 = new { Person = "Barney", Age = 28, CanCode = false };
            var v3 = new { Age = 28, Person = "Bill", CanCode = false };
        }
    }
}
