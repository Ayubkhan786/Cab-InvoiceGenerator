using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class CabInvoice
    {

        const double RATE_PER_KM = 10,
                     RATE_PER_MIN = 1,
                     MIN_FARE = 5;
        public double Fare(double km, double min)
        {
            double CalculatedFare = km * RATE_PER_KM + min * RATE_PER_MIN;

            if (CalculatedFare >= MIN_FARE)
            {
                return CalculatedFare;
            }
            return MIN_FARE;
        }
    }
}
