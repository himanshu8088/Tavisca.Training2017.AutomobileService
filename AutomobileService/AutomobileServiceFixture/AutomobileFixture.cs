using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using AutomobileService;

namespace AutomobileServiceFixture
{
    class AutomobileFixture
    {
        [Fact]
        public void Check_happy_flow()
        {
            Showroom showroom = new Showroom();
            ShowroomManager manager = new ShowroomManager(showroom);
            ServiceProvider provider = new ServiceProvider(manager);
            Vehicle vehicle = new Vehicle();
            provider.ProvideService(Service.Maintainence,vehicle);
            InvoiceGenerator generator = new InvoiceGenerator();
            generator.GenerateInvoice(Service.Maintainence, vehicle);
            ReportGenerator reportGenerator = new ReportGenerator();
            RecordManager recManager = new RecordManager();
            IReport serviceReport = new ServiceReport(recManager);
            reportGenerator.GenerateReport(serviceReport);

            throw new NotImplementedException();
        }
    }
}
