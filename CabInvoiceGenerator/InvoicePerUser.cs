using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoicePerUser
    {
        Dictionary<int, List<Rides>> repo = new Dictionary<int, List<Rides>>();

        public EnhancedInvoice UserFare(int userId)
        {
            CabInvoice cabInvoice = new CabInvoice();
            List<Rides> invoices = new List<Rides>();

            EnhancedInvoice res = new EnhancedInvoice(0, 0);
            if (repo.ContainsKey(userId))
            {
                invoices = repo[userId];

                if (invoices != null && invoices.Count > 0)
                {
                    res = cabInvoice.MultiRideFare(repo[userId]);
                }
            }
            return res;
        }

        public void AddRides(int userId, List<Rides> rides)
        {
            List<Rides> invoices = new List<Rides>();
            if (repo.ContainsKey(userId))
            {
                invoices = repo[userId];
            }

            foreach (var ride in rides)
            {
                invoices.Add(ride);
            }
            repo[userId] = invoices;
        }
        
    }
}
