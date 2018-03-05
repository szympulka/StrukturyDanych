using System;
using System.Diagnostics;
using System.Linq;
using StrukturyDanych.Helper;
using StrukturyDanych.Lab1;

namespace StrukturyDanych
{
    class Program
    {
        private static string path = @"C:\Work\2.csv";
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            var csv = new CSV.CSV();            
            var obj = csv.GetCsv(path);
            var array = obj.Select(x => x.Id).ToArray();
            OwnSort.BubbleSort(array);
            var asd = Factorial.Factorialfinder(5);
            stopWatch.Stop();
            var time = ParseTime.Parse(stopWatch.Elapsed);
        }
    }
}
