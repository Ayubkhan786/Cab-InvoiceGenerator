using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CabInvoiceGenerator;
namespace TDDCabInvoice
{
    [TestClass]
    public class UserInvoice
    {
        [TestMethod]
        public void TestInvoicePerUser()
        {
            int userId = 1;
            InvoicePerUser IPU = new InvoicePerUser();
            IPU.AddRides(1, new List<Rides>()
            {
                new Rides(20, 30),   //230
                new Rides(2, 3),     //23
                new Rides(12, 16),   //136
                new Rides(5, 7),     //57
                new Rides(19, 23)    //213
            });
            IPU.AddRides(2, new List<Rides>()
            {
                new Rides(20, 30),   //230
                new Rides(2, 3),     //23
                new Rides(12, 16),   //136
                new Rides(5, 7),     //57
                new Rides(19, 23)    //213
            });

            var res = IPU.UserFare(userId);
            Assert.AreEqual(659, res.totalFare);
        }

    }
}
