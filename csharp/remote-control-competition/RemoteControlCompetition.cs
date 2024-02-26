using System;
using System.Collections.Generic;

// TODO implement the IRemoteControlCar interface
public interface IRemoteControlCar 
{
	int DistanceTravelled { get; }
    void Drive();
}

public class ProductionRemoteControlCar : IRemoteControlCar, IComparable<ProductionRemoteControlCar>
{
    public int DistanceTravelled { get; private set; }
    public int NumberOfVictories { get; set; }

    public void Drive()
    {
        DistanceTravelled += 10;
    }

    public int CompareTo(ProductionRemoteControlCar otherProductionRemoteControlCar) =>
		otherProductionRemoteControlCar == null ? 1 : NumberOfVictories.CompareTo(otherProductionRemoteControlCar.NumberOfVictories);
}

public class ExperimentalRemoteControlCar : IRemoteControlCar
{
    public int DistanceTravelled { get; private set; }

    public void Drive()
    {
        DistanceTravelled += 20;
    }
}

public static class TestTrack
{
    public static void Race(IRemoteControlCar car)
    {
       car.Drive();
    }

    public static List<ProductionRemoteControlCar> GetRankedCars(ProductionRemoteControlCar prc1,
        ProductionRemoteControlCar prc2)
    {
        var carList = new List<ProductionRemoteControlCar>();
        if (prc1.CompareTo(prc2) < 0)
        {
            carList.Add(prc1);
            carList.Add(prc2);
        }
        else
        {
            carList.Add(prc2);
            carList.Add(prc1);
        }
        return carList;
	}
}
