
namespace Delegates.GlobalMotorcycleServiceModule
{
	public class MotorcycleService
	{
		public static int TotalDistance { get; set; }
		public MotorcycleService()
		{
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

		}
	}
}
