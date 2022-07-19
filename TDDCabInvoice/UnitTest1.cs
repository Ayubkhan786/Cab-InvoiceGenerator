using CabInvoiceGenerator;

namespace TDDCabInvoice
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CabFare()
        {
            CabInvoice invoice = new CabInvoice();
            double res = invoice.Fare(10,10);
            Assert.AreEqual(110,res);
        }
        
    }
}