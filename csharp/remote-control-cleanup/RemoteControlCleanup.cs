using RemoteControlCleanup;

public class RemoteControlCar
{
	private enum SpeedUnits
	{
		MetersPerSecond,
		CentimetersPerSecond
	}
	private struct Speed
	{
		public decimal Amount { get; }
		public SpeedUnits SpeedUnits { get; }

		public Speed(decimal amount, SpeedUnits speedUnits)
		{
			Amount = amount;
			SpeedUnits = speedUnits;
		}

		public override string ToString()
		{
			string unitsString = "meters per second";
			if (SpeedUnits == SpeedUnits.CentimetersPerSecond)
			{
				unitsString = "centimeters per second";
			}

			return Amount + " " + unitsString;
		}
	}
	
	private class Telemetry : ITelemetry
	{
		private RemoteControlCar _car;

		public Telemetry(RemoteControlCar car)
		{
			_car = car;
		}
		public void Calibrate()
		{
		}

		public bool SelfTest()
		{
			return true;
		}

		public void ShowSponsor(string sponsorName)
		{
			_car.SetSponsor(sponsorName);
		}

		public void SetSpeed(decimal amount, string unitsString)
		{
			SpeedUnits speedUnits = SpeedUnits.MetersPerSecond;
			if (unitsString == "cps")
			{
				speedUnits = SpeedUnits.CentimetersPerSecond;
			}

			_car.SetSpeed(new Speed(amount, speedUnits));
		}
	}
    public ITelemetry TelemetryInfo { get; }
	public string CurrentSponsor { get; private set; }

	private Speed currentSpeed;

	public RemoteControlCar()
	{
		TelemetryInfo = new Telemetry(this);
	}
	public string GetSpeed()
    {
        return currentSpeed.ToString();
    }

    private void SetSponsor(string sponsorName)
    {
        CurrentSponsor = sponsorName;

    }

    private void SetSpeed(Speed speed)
    {
        currentSpeed = speed;
    }

}


