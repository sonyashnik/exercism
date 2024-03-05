using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Reflection
{
    internal class Motorcycle
    {
        public const string motoState = "new";
        public string Name { get; set; }
        public string Model { get; set; }
        public int Acceleration { get; set; }

        public int Distance { get; set; }

        private int _vinNumber = 111;

        int _odometer;
        public int Odometer { get => _odometer; set => _odometer = value; }

        public Motorcycle()
        {
        }

        public Motorcycle(string name)
        {
            Name = name;
        }

        public Motorcycle(System.DateTime created, string name)
        {
        }

        public int GetVinNumber()
        {
            return _vinNumber;
        }
        public void Move(int km)
        {
            Acceleration = 1;
            Distance += km;
        
        }

        public override string ToString()
        {
            return $"Motorcycle: {Name}, Model: {Model}, Odometer: {Odometer}, VinNumber: {GetVinNumber()}, State: {motoState}";
        }

        class TechnicalInfo { };
    }
}
