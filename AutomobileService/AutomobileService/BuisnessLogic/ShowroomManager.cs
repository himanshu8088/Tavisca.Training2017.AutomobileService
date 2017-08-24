using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileService
{
    public class ShowroomManager
    {
        private Showroom _showroom;
        public ShowroomManager(Showroom showroom)
        {
            _showroom = showroom;
        }

        public void AddVehicle(Vehicle vehicle, VehicleTag tag)
        {
            List<Vehicle> vehicles=_showroom.Vehicles[tag];
            vehicles.Add(vehicle);
            _showroom.Vehicles[tag]=vehicles;
        }
        public void TakeOutVehicle(int code)
        {
            throw new NotImplementedException();
        }
    }
}
