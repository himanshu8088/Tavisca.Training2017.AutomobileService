using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileService
{
    public class ReportGenerator
    {
        public string GenerateReport(IReport report)
        {
            return report.ToString();
        }
    }
}
