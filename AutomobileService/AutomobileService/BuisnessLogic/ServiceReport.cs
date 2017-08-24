using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileService
{
    public class ServiceReport : IReport
    {
        private RecordManager _manager;

        public ServiceReport(RecordManager manager)
        {
            _manager = manager;
        }

        public override string ToString()
        {
            return $"Maintainence:{ _manager.ServiceDictionary[Service.Maintainence]} Sell:{ _manager.ServiceDictionary[Service.Sell]} Rent:{ _manager.ServiceDictionary[Service.Rent]} TestDrive:{ _manager.ServiceDictionary[Service.TestDrive]}";
        }
    }
}
