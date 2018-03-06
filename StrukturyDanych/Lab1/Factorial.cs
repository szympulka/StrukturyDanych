using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrukturyDanych.Lab1
{
    public class Factorial
    {
        public static Int64 Factorialfinder(Int64 x)
        {
            if (x == 1)        
                return 1;

            PerformanceCounter cpuCounter;

            cpuCounter = new PerformanceCounter();

            cpuCounter.CategoryName = "Processor";

            cpuCounter.CounterName = "% Processor Time";

            cpuCounter.InstanceName = "_Total";

            // Get Current Cpu Usage

            string currentCpuUsage =
                cpuCounter.NextValue() + "%";
            return x * Factorialfinder(x - 1); 

        }
    }
}
