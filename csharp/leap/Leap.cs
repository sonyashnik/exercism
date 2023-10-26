using System;
using System.ComponentModel.Design;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        bool isDiv4 = year % 4 ==0;
        bool isDiv100 = year % 100 == 0;
        bool isDiv400 = year % 400 == 0;
        return ((isDiv4 && !isDiv100) || (isDiv4 && isDiv100 && isDiv400));
    }
}