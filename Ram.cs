using System;
using System.Collections.Generic;

namespace Inheritance
{
    public class Ram : Vehicle, IGasVehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public double BatteryKWh { get; set; }
        public double CurrentTankPercentage { get; set; }
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram drives fast. RRrrrrrummbbble!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Vehicle  turns to {direction}!");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram rolls to a stop.");
        }
    }
}