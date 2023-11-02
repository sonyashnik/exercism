using System;

public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum) => shirtNum switch
    {
        1 => "goalie",
        2 => "left back",
        3 or 4 => "center back",
        5 => "right back",
        6 or 7 or 8 => "midfielder",
        9 => "left wing",
        10 => "striker",
        11 => "right wing",
        _ => throw new ArgumentOutOfRangeException(),
    };
 /*   {
        switch (shirtNum)
        {
            case 1:
                return "goalie";
                break;
            case 2:
                return "left back";
                break;

            case 3:
            case 4:
                return "center back";
                break;
            case 5:
                return "right back";
                break;
            case 6:
            case 7:
            case 8:
                return "midfielder";
                break;
            case 9:
                return "left wing";
                break;
            case 10:
                return "striker";
                break;
            case 11:
                return "right wing";
                break;
            default:
                throw new ArgumentOutOfRangeException();
                break;

        }

    }
*/
public static string AnalyzeOffField(object report) => report switch
{
    Injury injury => $"Oh no! {injury.GetDescription()} Medics are on the field.",
    Manager manager => manager.Club == null ? manager.Name : $"{manager.Name} ({manager.Club})",
    Incident incident => incident.GetDescription(),
    int supporters => $"There are {supporters} supporters at the match.",
    string general => general,
    _ => throw new ArgumentException()
};
    /*    {
            switch (report)
            {
                case int supporters:
                    return $"There are {supporters} supporters at the match.";
                    break;
                case String announcements:
                    return announcements;
                    break;
                case Incident incident:
                    switch (incident)
                    {
                        case Foul:
                            return incident.GetDescription();
                            break;
                        case Injury:
                            return $"Oh no! {incident.GetDescription()} Medics are on the field.";
                            break;
                        default:
                            return incident.GetDescription();
                            break;
                    }

                    break;
                case Manager manager:
                    var clubPrinted = manager.Club != null ? $" ({manager.Club})" : string.Empty;
                    return $"{manager.Name}{clubPrinted}";
                default:
                    throw new ArgumentException();
                    break;


            }
        }
    */
}
