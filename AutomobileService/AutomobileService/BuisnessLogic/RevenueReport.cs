using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileService
{
    public class RevenueReport : IReport
    {
        private double _revenue=0;
        public RevenueReport(double _revenue)
        {
            _revenue++;
        }
        double Revenue => _revenue;

        public override string ToString()
        {
            return $"Revenue: {_revenue}";
        }
    }
}
