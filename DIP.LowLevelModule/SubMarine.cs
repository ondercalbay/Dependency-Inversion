using System;
using DIP.Abstraction;

namespace DIP.LowLevelModule
{
    public class SubMarine
        :IVehicle
    {
        public void Fire()
        {
            Console.WriteLine("Fire from Submarine");
        }

        public void Move()
        {
            Console.WriteLine("SubMarine on the move");
        }
    }
}
