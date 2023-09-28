using System;

static class AssemblyLine
{
    const int Capacity = 221;
    const int minutesInHour = 60;

    public static double SuccessRate(int speed)
    {
        if (speed == 0)
            return 0;
        else if (speed >= 1 & speed <= 4)
            return 1;
        else if (speed >= 5 & speed <= 8)
            return 0.9;
        else if (speed == 9)
            return 0.8;
        else
            return 0.77;
    }
    public static double ProductionRatePerHour(int speed)
    {
        var Rate = SuccessRate(speed);
        return (speed * Capacity * Rate);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        var productionRatePerHour = ProductionRatePerHour(speed);
        return ((int)(productionRatePerHour / minutesInHour));
    }
}

