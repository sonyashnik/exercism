using Delegates.GlobalMotorcycleServiceModule;

namespace Delegates.MotorcycleConsole
{
	class Programm
	{
		static void Main(string[] args)
		{
			//Option 1
			//MotoServiceDelegate @delegate = new MotoServiceDelegate(GoToService);
			//Option 2
			MotoServiceDelegate @delegate = GoToService;
			@delegate += SendSMS;

			MotorcycleService service = new MotorcycleService(@delegate);
			MyConsoleMotorcycle motorcycle = new("Honda");
			motorcycle.StartEngine();
			motorcycle.Move(1_000);
			motorcycle.Move(1_000);
			motorcycle.StopEngine();
			motorcycle = null;
			service = null;

			service = new MotorcycleService(@delegate);
			motorcycle = new("Honda");
			motorcycle.StartEngine();
			motorcycle.Move(1_000);
			motorcycle.Move(1_000);
			motorcycle.StopEngine();
			motorcycle = null;
			service = null;

			service = new MotorcycleService(@delegate);
			motorcycle = new("Honda");
			motorcycle.StartEngine();
			motorcycle.Move(3_000);
			motorcycle.Move(4_000);
			motorcycle.StopEngine();
			motorcycle = null;
			service = null;
			service = null;

			service = new MotorcycleService(@delegate);
		}

		static void GoToService(int curentTotalDistance)
		{
			Console.WriteLine($"Time to go to motoservice. Current distance of your bike: {curentTotalDistance} km.");
		}

		static void SendSMS(int curentTotalDistance)
		{
			Console.WriteLine($"SMS:Time to go to motoservice. Current distance of your bike: {curentTotalDistance} km.");
		}
	}
}