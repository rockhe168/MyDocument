﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton_安全的线程_
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Singleton.Instance == Singleton.Instance)
                Console.WriteLine("同一对象");
            else
                Console.WriteLine("不同的对象");

            Console.ReadKey();
        }
    }
}
