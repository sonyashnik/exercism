using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
public static class Tournament
{

    private const string TableHeader = "Team                           | MP |  W |  D |  L |  P";
    public class TournamentResult
    {
        public string TeamName { get; set; }
        public int WinCount { get; set; } = 0;
        public int DrawCount { get; set; } = 0;
        public int LossCount { get; set; } = 0;
        public int MatchPlayed { get { return WinCount + DrawCount + LossCount; } }
        public int Points
        {
            get { return WinCount * 3 + DrawCount; }
        }
    }
    public static void Tally(Stream inStream, Stream outStream)
    {
        var dic = new Dictionary<string, TournamentResult>();
        using StreamReader sr = new StreamReader(inStream);
        while (sr.Peek() > 0)
        {
            string[] resultFromLine = sr.ReadLine().Split(';');
            if (!dic.ContainsKey(resultFromLine[0]))
            {
                dic[resultFromLine[0]] = new TournamentResult() { TeamName = resultFromLine[0] };
            }
            if (!dic.ContainsKey(resultFromLine[1]))
            {
                dic[resultFromLine[1]] = new TournamentResult() { TeamName = resultFromLine[1] };
            }
            switch (resultFromLine[2])
            {
                case "loss":
                    dic[resultFromLine[0]].LossCount++;
                    dic[resultFromLine[1]].WinCount++;
                    break;
                case "win":
                    dic[resultFromLine[0]].WinCount++;
                    dic[resultFromLine[1]].LossCount++;
                    break;
                case "draw":
                    dic[resultFromLine[0]].DrawCount++;
                    dic[resultFromLine[1]].DrawCount++;
                    break;
                default:
                    break;
            }
        }
        sr.Close();
        var sb = new StringBuilder();
        
        sb.Append(TableHeader);
        if (dic.Count > 0) sb.Append('\n');
        var dicOrdered = dic
            .OrderByDescending(_=>_.Value.Points)
            .ThenBy(_=>_.Value.TeamName)
            .ToDictionary(_=>_.Key,_=>_.Value);
        foreach (string teams in dicOrdered.Keys)
        {
            sb.Append($"{dicOrdered[teams].TeamName.PadRight(31)}|" +
                $"{dicOrdered[teams].MatchPlayed.ToString().PadLeft(3)} |" +
                $"{dicOrdered[teams].WinCount.ToString().PadLeft(3)} |" +
                $"{dicOrdered[teams].DrawCount.ToString().PadLeft(3)} |" +
                $"{dicOrdered[teams].LossCount.ToString().PadLeft(3)} |" +
                $"{dicOrdered[teams].Points.ToString().PadLeft(3)}\n");
        }
        if (dic.Count > 0)  sb.Remove(sb.Length - 1, 1);
        byte[] bytesToWrite = Encoding.UTF8.GetBytes(sb.ToString());
        outStream.Write(bytesToWrite, 0, bytesToWrite.Length);
        outStream.Close();
    }
}
