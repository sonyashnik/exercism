using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._4.Task._1.String.Extension
{
    static class StringHelper
    {
        public static string GetString(this string str) 
        { 
            return $"{str.Substring(0,5)}...";
        }
    }
}
