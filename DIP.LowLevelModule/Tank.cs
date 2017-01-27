using System;
using DIP.Abstraction;

namespace DIP.LowLevelModule
{
    public class Tank
        :IVehicle
    {

        public void Fire()
        {
            Console.WriteLine("Fire from Tank.");
        }

        public void Move()
        {
            Console.WriteLine("Plane on the move.");
        }
    }
}
