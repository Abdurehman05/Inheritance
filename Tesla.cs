using System;
using System.Collections.Generic;

namespace Inheritance
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {

        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla drives fast. Vroooom!");
        }
    }
}