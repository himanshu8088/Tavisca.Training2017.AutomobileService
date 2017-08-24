using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileService
{
    public class RecordManager
    {
        private double _revenue = 0;
        private Dictionary<Service, int> _serviceDictionary = new Dictionary<Service, int>()
        {
            { Service.Maintainence,0},
            { Service.Rent,0},
            { Service.Sell,0},
            { Service.TestDrive,0}
        };

        public Dictionary<Service, int> ServiceDictionary => _serviceDictionary;
        public double Revenue => _revenue;

        public void UpdateRevenueRecord(double revenue)
        {
            _revenue = _revenue + revenue;
        }

        public void UpdateServiceRecord(Service service)
        {
            _serviceDictionary[service] = _serviceDictionary[service] + 1;
        }
    }
}
