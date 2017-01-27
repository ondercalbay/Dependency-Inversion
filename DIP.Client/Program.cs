using System;
using DIP.Abstraction;
using DIP.HightLevelModule;
using DIP.LowLevelModule;

namespace DIP.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //IVehicle vehicle = new Tank();
            IVehicle vehicle = new Plane();

            VehicleController lee = new VehicleController(vehicle);

            lee.FireToEnemy();
            lee.MoveToSomeWhere();

            Console.ReadKey();
        }
    }
}

//bir interfacin kendisini implemente eden tşipleri taşıması ne anlama gelebilir