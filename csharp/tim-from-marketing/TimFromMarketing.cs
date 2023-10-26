using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        var printId = id != null ? $"[{id}] - " : string.Empty;
        var printDep = department != null ? department?.ToUpper() : "OWNER";
        return $"{printId}{name} - {printDep}";
    }
}
