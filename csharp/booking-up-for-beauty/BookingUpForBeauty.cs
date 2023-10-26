using System;
using System.Globalization;

static class Appointment
{
   
    public static DateTime Schedule(string appointmentDateDescription)
    {
        return DateTime.Parse(appointmentDateDescription, new CultureInfo("en-US",false));
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        return appointmentDate < DateTime.Now;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        var t1 = new TimeSpan(12, 0, 0);
        var t2 = new TimeSpan(18, 0, 0);
        return (appointmentDate.TimeOfDay >= t1 && appointmentDate.TimeOfDay < t2);
    }

    public static string Description(DateTime appointmentDate)
    {
        return $"You have an appointment on {appointmentDate.ToString(new CultureInfo("en-US", false))}.";
    }

    public static DateTime AnniversaryDate()
    {
        return new DateTime(DateTime.Now.Year, 9, 15, 0, 0, 0); ;
    }
}
