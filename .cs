﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Day_6_Assignments
{
    internal class StopWatch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("stopwatch");
            var stopwatch = new Stopwatch();

            Console.WriteLine("press enter to start");
            Console.ReadLine();
            stopwatch.Start();

            Console.WriteLine("press enter to stop");
            Console.ReadLine();
            stopwatch.Stop();

            var elapsed_time = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"{elapsed_time / 1000} seconds");
        }
    }
}
