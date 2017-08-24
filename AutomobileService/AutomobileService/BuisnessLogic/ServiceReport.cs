using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileService
{
    public class ServiceReport : IReport
    {
        private Dictionary<Service, int> _serviceDictionary = new Dictionary<Service, int>()
        {
            { Service.Maintainence,0},
            { Service.Rent,0},
            { Service.Sell,0},
            { Service.TestDrive,0}
        };

        public ServiceReport(Service service)
        {
            _serviceDictionary[service]= _serviceDictionary[service]+1;
        }
        Dictionary<Service, int> ServiceDictionary => _serviceDictionary;

        public override string ToString()
        {
            return $"Maintainence:{ _serviceDictionary[Service.Maintainence]} Sell:{ _serviceDictionary[Service.Sell]} Rent:{ _serviceDictionary[Service.Rent]} TestDrive:{ _serviceDictionary[Service.TestDrive]}";
        }
    }
}
