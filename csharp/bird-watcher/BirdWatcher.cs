class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {

        return  new int[] { 0, 2, 5, 3, 7, 8, 4 };
    }

    public int Today()
    {
        int todayNr = birdsPerDay.Length - 1;
        return birdsPerDay[todayNr];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1] ++;
    }

    public bool HasDayWithoutBirds()
    {
        bool birds = false;
        foreach (int birdsCount in birdsPerDay)
        {
            if (birdsCount == 0)
            {
                birds =  true;
            }
 
        }
        return birds;

    }

    public int CountForFirstDays(int numberOfDays)
    {
        int birdCount = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
             birdCount += birdsPerDay[i];

        }
        return birdCount;
    }

    public int BusyDays()
    {
        int busyDayCount = 0;
        foreach (int birdsCount in birdsPerDay)
        {
            if (birdsCount >= 5) 
            {
                busyDayCount++;
            }
        }
        return busyDayCount;
    }
}
