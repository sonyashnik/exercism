// See https://aka.ms/new-console-template for more information
using System.Text;

String str = "My    Id";
StringBuilder sb = new StringBuilder(str);
sb.Replace(' ', '_');
Console.WriteLine(sb.ToString());
