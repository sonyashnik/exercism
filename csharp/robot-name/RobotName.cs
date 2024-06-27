using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

public class Robot
{
    private string _name = String.Empty;
    private HashSet<string> _robotNames = new HashSet<string>();
    public string Name
    {
        get
        {
            return _name;
        }
    }
    public Robot()
    { 
        _name = GenerateUniqueName(); 
    }

    public void Reset()
    {
        _robotNames.Remove(_name);
        _name = String.Empty;
        _name = GenerateUniqueName();
    }

    public string GenerateName()
    {
        var rnd = new Random();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        var sb = new StringBuilder();
        for (int i = 0; i < 2; i++)
        {
            sb.Append(chars[rnd.Next(0, chars.Length)]);
        }
        for (int i = 0; i < 3; i++)
        {
            sb.Append(rnd.Next(0, 9));
        }
        return sb.ToString();
    }
    public string GenerateUniqueName()
    {
        var name = GenerateName();
        while (!_robotNames.Add(name))
        {
            name = GenerateName();
        }
        return name;
    }
}