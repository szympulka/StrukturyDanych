using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CSV;
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
            var csvObj = new List<CsvObject>()
            {                new CsvObject() { Id = 23},
                new CsvObject() {Id = 25},
                new CsvObject() {Id = 23}
            };
            var csv = new CSV.CSV();
            csv.GetCsv(path);

            var asd = Factorial.Factorialfinder(20);
            var aa = Fibonaci.Fib(30);
            stopWatch.Stop();
            var aaaa = ParseTime.Parse(stopWatch.Elapsed);
        }
    }
}
