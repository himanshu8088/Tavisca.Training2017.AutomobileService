using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileService
{
    public class Showroom
    {

        private Dictionary<VehicleTag, List<Vehicle>> vehicles;
        public Showroom()
        {
            vehicles = new Dictionary<VehicleTag, List<Vehicle>>();
            vehicles.Add(VehicleTag.OnRent,null);
            vehicles.Add(VehicleTag.OnSell, null);
        }
        public Dictionary<VehicleTag, List<Vehicle>> Vehicles { get; set; }
    }
}
