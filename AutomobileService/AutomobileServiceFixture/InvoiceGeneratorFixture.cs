using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using AutomobileService;

namespace AutomobileServiceFixture
{
    class InvoiceGeneratorFixture
    {
        [Fact]
        public void Invoice_should_genrate_properly()
        {
            InvoiceGenerator generator = new InvoiceGenerator();
        }
        
    }
}
