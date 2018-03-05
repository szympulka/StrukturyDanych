using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrukturyDanych.Lab1
{
    public class OwnSort
    {
         public static void BubbleSort(double[] arr)
         {
             double t;
             for (var p = 0; p < arr.Length -2; p++)
             {
                 for (var j = 0; j < arr.Length -2; j++)
                 {
                     if ((arr[j] > arr[j + 1]))
                     {
                         t = arr[j + 1];
                         arr[j + 1] = arr[j];
                         arr[j] = t;
                     }
                 }
             }
         } 
    }
}
