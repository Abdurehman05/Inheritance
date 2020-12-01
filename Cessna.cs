using System;
using System.Collections.Generic;

namespace Inheritance
{
    public class Cessna : Vehicle, IGasVehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }
        public double CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna drives fast. Zooommmm!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The white Cessna rolls to a stop as if it never moved.");
        }
    }
}