
using System;

namespace Delegates.GlobalMotorcycleServiceModule
{
	public delegate void MotoServiceDelegate(int totalDistance);
	public class MotorcycleService
	{
		private MotoServiceDelegate _motoServiceDelegate;
		public static int TotalDistance { get; set; }
		public MotorcycleService()
		{
			CheckDistance();
		}
		public MotorcycleService(MotoServiceDelegate @delegate)
		{
			_motoServiceDelegate = @delegate;
			CheckDistance();

		}
		private void CheckDistance()
		{
			if (TotalDistance >= 10_000)
			{
				NotifyAboutDistance();
			}
		}
		private void NotifyAboutDistance()
		{
			//Option 1
			_motoServiceDelegate.Invoke(TotalDistance);
			//Option 2
			//_motoServiceDelegate(TotalDistance);

		}
	}
}
