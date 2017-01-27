using System;
using DIP.Abstraction;

namespace DIP.LowLevelModule
{
    public class Plane
        :IVehicle
    {
        public void Fire()
        {
            Console.WriteLine("Fire from Plane.");
        }

        public void Move()
        {
            Console.WriteLine("Plane on the Plane.");
        }
    }
}
