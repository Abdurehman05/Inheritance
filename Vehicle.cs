using System;
using System.Collections.Generic;

namespace Inheritance
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");

        }

        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The Vehicle  turns to {direction}!");
        }

        public virtual void Stop()
        {
            Console.WriteLine("The Vehicle Zero rolls to a stop!");
        }
    }
}

