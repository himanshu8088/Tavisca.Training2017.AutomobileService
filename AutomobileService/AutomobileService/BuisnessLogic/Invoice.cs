using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileService
{
    public class Invoice
    {                        
        public Service ServiceType { get; set; }
        public double Amount { get; set; }
        public DateTime ServiceDate { get; set; }
    }
}
