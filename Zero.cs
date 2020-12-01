using System;
using System.Collections.Generic;

namespace Inheritance
{
    public class Zero : Vehicle, IElectricVehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public double CurrentChargePercentage { get; set; }
        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero drives fast. Drooom!");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Zero rolls to a stop.");
        }
    }
}