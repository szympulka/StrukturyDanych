using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using CSV;
using StrukturyDanych.Helper;
using StrukturyDanych.Lab1;

namespace StrukturyDanych
{
    class Program
    {
        private static string path = @"C:\Work\2.csv";
        private static string path1 = @"C:\Work\11.csv";
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();

            var csv = new CSV.CSV<CsvObject>();
            var obj = csv.GetCsv(path);
            var timeList = new List<CsvHelper>();

            Factorial.Factorialfinder(20);
            //int helper = 5;
            //var array = obj.Select(x => x.Id).ToArray();


            //while (helper < array.Length)
            //{
            //    stopWatch.Start();
            //    OwnSort.BubbleSort(array.Take(helper).ToArray());
            //    stopWatch.Stop();
            //    timeList.Add(new CsvHelper(){Count = helper/5,Time = stopWatch.Elapsed.TotalMilliseconds});
            //    stopWatch.Reset();
            //    helper += 5;
            //}
            //csv.SaveCsv(path1,timeList);
        }
    }
}
