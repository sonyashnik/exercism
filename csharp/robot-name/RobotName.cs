using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

public class Robot
{
    private static readonly Random Rnd = new Random();
    private static HashSet<string> _robotNames = new HashSet<string>();
    public string Name { get; private set; }
    public Robot()
    {
        Reset();
    }

    public void Reset()
    {
         Name = GenerateUniqueName();
    }

    private string GenerateName()
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        var sb = new StringBuilder();
        for (int i = 0; i < 2; i++)
        {
            sb.Append(chars[Rnd.Next(0, chars.Length)]);
        }
        for (int i = 0; i < 3; i++)
        {
            sb.Append(Rnd.Next(0, 10));
        }
        return sb.ToString();
    }
    private string GenerateUniqueName()
    {
        var name = GenerateName();
        while (!_robotNames.Add(name))
        {
            name = GenerateName();
        }
        return name;
    }
}