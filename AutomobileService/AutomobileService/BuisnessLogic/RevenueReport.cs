using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileService
{
    public class RevenueReport : IReport
    {
        private double _revenue;
        public RevenueReport(double revenue)
        {
            _revenue = revenue;
        }
        
        public override string ToString()
        {
            return $"Revenue: {_revenue}";
        }
    }
}
