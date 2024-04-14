using System;
using System.Globalization;


public enum Location
{
    NewYork,
    London,
    Paris
}

public enum AlertLevel
{
    Early,
    Standard,
    Late
}

public static class Appointment
{
	private static bool isWindows = OperatingSystem.IsWindows();
	public static DateTime ShowLocalTime(DateTime dtUtc) => dtUtc.ToLocalTime();

    public static DateTime Schedule(string appointmentDateDescription, Location location)
    {
		//		DateTime dateValue = DateTime.Parse(appointmentDateDescription, new CultureInfo("en-US",false));
		DateTime dateValue = DateTime.Parse(appointmentDateDescription, GetCulture(location));   
		return TimeZoneInfo.ConvertTimeToUtc(dateValue, GetTimeZone(location));
	}

	public static DateTime GetAlertTime(DateTime appointment, AlertLevel alertLevel)
    {
        TimeSpan ts = alertLevel switch
        {
            AlertLevel.Early => new TimeSpan(24, 0, 0),
            AlertLevel.Standard => new TimeSpan(1, 45, 0),
            AlertLevel.Late => new TimeSpan(0, 30, 0),
            _ => throw new ArgumentOutOfRangeException()
        };
        return appointment - ts;
    }

    public static bool HasDaylightSavingChanged(DateTime dt, Location location)
    {
        DateTime dtBefore = dt.AddDays(-7);
		TimeZoneInfo tz = GetTimeZone(location);

		return tz.IsDaylightSavingTime(dt) != tz.IsDaylightSavingTime(dtBefore);
    }

    public static DateTime NormalizeDateTime(string dtStr, Location location)
    {
		var isSuccess = DateTime.TryParse(dtStr, GetCulture(location), out var dateTime);
		return isSuccess ? dateTime : new(1, 1, 1);
	}
     
    public static TimeZoneInfo GetTimeZone(Location location)
    {
        TimeZoneInfo tz = location switch
        {
            Location.NewYork => isWindows ? TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"): TimeZoneInfo.FindSystemTimeZoneById("America/New_York"),
            Location.London => isWindows ? TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time"): TimeZoneInfo.FindSystemTimeZoneById("Europe/London"),
            Location.Paris => isWindows ? TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time"): TimeZoneInfo.FindSystemTimeZoneById("Europe/Paris"),

			_ => throw new ArgumentOutOfRangeException()
        };
        return tz;
    }

	public static CultureInfo GetCulture(Location location)
	{
		CultureInfo culture = location switch
		{
			Location.NewYork => new CultureInfo("en-US", false),
			Location.London => new CultureInfo("en-GB", false),
			Location.Paris => new CultureInfo("fr-FR", false),
			_ => throw new ArgumentOutOfRangeException()
		};
		return culture;
	}
}
