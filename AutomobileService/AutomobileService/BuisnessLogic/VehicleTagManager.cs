using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileService
{
    public class VehicleTagManager
    {
        private Dictionary<int, VehicleTag> _onRentVehicles;
        private Dictionary<int, VehicleTag> _onSellVehicles; 

        public VehicleTagManager()
        {
            _onRentVehicles = new Dictionary<int, VehicleTag>();
            _onSellVehicles = new Dictionary<int, VehicleTag>();
        }

        public Dictionary<int, VehicleTag> OnRentVehicles => _onRentVehicles;
        public Dictionary<int, VehicleTag> OnSellVehicles => _onSellVehicles;

        public void SetTag(int code, VehicleTag tag)
        {
            if (tag == VehicleTag.OnRent)
                _onRentVehicles.Add(code, tag);
            else
                _onSellVehicles.Add(code, tag);                
        }
    }
}
