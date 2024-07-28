using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

public class GradeSchool
{
    private Dictionary<string,int> _studentInfos { get; set; }= new();
    public GradeSchool()
    {
    }

    public bool Add(string student, int grade) => _studentInfos.TryAdd(student, grade);

    public IEnumerable<string> Roster() => _studentInfos
        .OrderBy(_ =>_.Value)
        .ThenBy(_ => _.Key)
        .Select(_ => _.Key);

    public IEnumerable<string> Grade(int grade) => _studentInfos
        .Where(_=>_.Value == grade)
        .OrderBy(_=>_.Key)
        .Select(_=>_.Key);

}