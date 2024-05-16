using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegates.GlobalMotorcycleServiceModule;

namespace Delegates.MotorcycleConsole
{
	internal sealed class MyConsoleMotorcycle
	{
        public string Model { get; set; }
        public static int Odometer { get; set; }       

        public int DailyDistance { get; set; }

        public MyConsoleMotorcycle(string model)
        {
            Model = model;
        }

        public void StartEngine() 
        {
            Console.WriteLine();
            Console.WriteLine("Engine started.");
        }
        public void Move(int distance)
        {
            DailyDistance += distance;
            Console.WriteLine($"Move to {distance} km.");
        }
        public void StopEngine() 
        { 
            Odometer += DailyDistance;
            MotorcycleService.TotalDistance += DailyDistance;
            Console.WriteLine("Engine stoped."); 
            Console.WriteLine($"Total distance: {Odometer} km."); 
        }
    }
}
