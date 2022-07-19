using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CabInvoiceGenerator;
namespace TDDCabInvoice
{
    [TestClass]
    public class PremiumRides
    {
        [TestMethod]
        public void PremiumRide()
        {
            CabInvoice Invoice = new CabInvoice();
            List<Rides> rides = new List<Rides>()
        {
                new Rides(20, 30,true),   //360
                new Rides(2, 3),          //23
                new Rides(12, 16,true),   //212
                new Rides(5, 7),          //57
                new Rides(19, 23,true)    //331
        };
            EnhancedInvoice res = Invoice.MultiRideFare(rides);
            Assert.AreEqual(659, res.totalFare);
        }
    }
}
