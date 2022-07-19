using CabInvoiceGenerator;

namespace TDDCabInvoice
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CabFare()
        {
            CabInvoice Invoice = new CabInvoice();
            double res = Invoice.Fare(10, 10);
            Assert.AreEqual(110, res);
        }

        [TestMethod]
        public void MultiRideFare()
        {
            CabInvoice Invoice = new CabInvoice();
            List<Rides> rides = new List<Rides>()
            {
                new Rides(20, 30),   //230
                new Rides(2, 3),     //23
                new Rides(12, 16),   //136
                new Rides(5, 7),     //57
                new Rides(19, 23)    //213
        };
            double res = Invoice.MultiRideFare(rides);
            Assert.AreEqual(659, res);
        }
    }
}