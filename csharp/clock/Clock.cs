using System;

public class Clock :IEquatable<Clock>
{
    private const int MinutesInHour = 60;
    private const int MinutesInDay = 1440;
    private TimeOnly _timeOnly;
    public Clock(int hours, int minutes = 0)
    {
        int totalMinutes = hours * MinutesInHour + minutes;
        while (totalMinutes < 0)
        {
            totalMinutes += MinutesInDay;
        }
        while (totalMinutes >= MinutesInDay)
        {
            totalMinutes %= MinutesInDay;
        }

        _timeOnly = new TimeOnly(totalMinutes / MinutesInHour, totalMinutes % MinutesInHour);
    }

    public Clock Add(int minutesToAdd) => new Clock(_timeOnly.AddMinutes(minutesToAdd).Hour, _timeOnly.AddMinutes(minutesToAdd).Minute);

    public Clock Subtract(int minutesToSubtract) => new Clock(_timeOnly.AddMinutes(-minutesToSubtract).Hour, _timeOnly.AddMinutes(-minutesToSubtract).Minute);

    public bool Equals(Clock other)
    {
      if (other == null)
         return false;

      if (this._timeOnly.Hour == other._timeOnly.Hour && this._timeOnly.Minute == other._timeOnly.Minute)
         return true;
      else
         return false;
    }
    public override bool Equals(Object obj)
    {
        if (obj == null)
            return false;

        Clock clockObj = obj as Clock;
        if (clockObj == null)
            return false;
        else
            return Equals(clockObj);
    }
    public override string ToString() => $"{_timeOnly.Hour:00}:{_timeOnly.Minute:00}";
}
