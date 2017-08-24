using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileService.BuisnessLogic
{
    public class ServiceProvider
    {
        private ShowroomManager _manager;
        public ServiceProvider(ShowroomManager manager)
        {
            _manager = manager;
        }
        public void ProvideService(Service type,Vehicle vehicle)
        {
            _manager.TakeOutVehicle(vehicle.Code);
        }   
    }
}
