using DIP.Abstraction;

namespace DIP.HightLevelModule
{
    public class VehicleController
    {
        IVehicle _vehicle;

        public VehicleController(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public void FireToEnemy()
        {
            _vehicle.Fire();
        }

        public void MoveToSomeWhere()
        {
            _vehicle.Move();
        }
    }
}
