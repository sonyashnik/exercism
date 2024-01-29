using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._4.Task._1.String.Extension
{
    static class StringExtension
    {
        public static string GetString(this string str) 
        { 
            return str.Length >5?$"{str.Substring(0,5)}..." : str;
        }
    }
}
