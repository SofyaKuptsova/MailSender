﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace TestConsole
{
    static class Program
    {
        static void Main(string[] args)
        {
            //ExcelCreator.Create();
            //ThreadsTest.Start();
            ThreadPoolTest.Start();

            Console.WriteLine("Главный поток завершил работу!");
            Console.ReadLine();
        }
    }
}
