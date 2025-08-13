using System;
using System.Collections.Generic;

namespace Transportmidler
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>
            {
                new Car("Toyota", "Corolla", 180),
                new Boat("Yamaha", "WaveRunner", 80),
                new Plane("Boeing", "737", 900)
            };

            foreach (var vehicle in vehicles)
            {
                vehicle.Drive();
                vehicle.FuelUp(50);
            }
        }
    }
}
