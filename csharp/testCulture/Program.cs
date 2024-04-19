// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");
CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
//			Location.London => new CultureInfo("en-GB", false),
//			Location.Paris => new CultureInfo("fr-FR", false),

DateTime dt1 = DateTime.Now;
Console.WriteLine(dt1.ToString());
CultureInfo.CurrentCulture = new CultureInfo("en-GB", false);
DateTime dt2 = DateTime.Now;
Console.WriteLine(dt2.ToString());
CultureInfo.CurrentCulture = new CultureInfo("fr-FR", false);
DateTime dt3 = DateTime.Now;
Console.WriteLine(dt3.ToString());
