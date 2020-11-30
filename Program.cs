using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Tesla myTesla = new Tesla()
            {
                MainColor = "Black"
            };
            Zero myZero = new Zero()
            {
                MainColor = "Blue"
            };
            Cessna myCessna = new Cessna()
            {
                MainColor = "Silver"
            };
            Ram myRam = new Ram()
            {

                MainColor = "Maroon"
            };

            myTesla.Drive();
            myZero.Drive();
            myCessna.Drive();
            myRam.Drive();
        }
    }
}
