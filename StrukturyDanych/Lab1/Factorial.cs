using System;
using System.Collections.Generic;
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

            return x * Factorialfinder(x - 1); 

        }
    }
}
