using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using CSV;
using StrukturyDanych.Helper;
using StrukturyDanych.Lab1;
using StrukturyDanych.Lab2;

namespace StrukturyDanych
{
    class Program
    {
        private static string read = @"C:\Work\alp.csv";
        private static string save = @"C:\Work\1.csv";
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();

            List.GetWords(read);
            stopWatch.Start();
            var word = List.FindPL("abacie");
            stopWatch.Stop();
            var time = ParseTime.Parse(stopWatch.Elapsed);

        }
    }
}
