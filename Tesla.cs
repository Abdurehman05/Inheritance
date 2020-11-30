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
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Vehicle  turns to {direction}!");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla gently rolls to a stop.");
        }
    }
}