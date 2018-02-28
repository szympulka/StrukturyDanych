using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrukturyDanych.Helper
{
    public class ParseTime
    {
        public static string Parse(TimeSpan stopWatch)
        {
            TimeSpan ts = stopWatch;
            return String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
        }
    }
}
