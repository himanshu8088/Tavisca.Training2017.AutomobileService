using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileService
{
    public class InvoiceGenerator
    {
        public Invoice GenerateInvoice(Service type,Vehicle vehicle)
        {
            Invoice bill = new Invoice();
            bill.Amount = GetAmount(type,vehicle);
            bill.ServiceDate = System.DateTime.Now;
            bill.ServiceType = type;
            return bill;
        }

        private double GetAmount(Service type, Vehicle vehicle)
        {
            double amount=0;
            if (type == Service.Maintainence)
                amount = 500;
            else if (type == Service.Sell)
                amount = vehicle.Price;
            else if (type == Service.TestDrive)
                amount = 0;
            else
                amount = 2000;

            return amount;

        }
    }
}
