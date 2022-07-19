using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class Rides
    {
        public readonly double km = 0,
                               min = 0;
        public Rides(double km, double min)
        {
            this.km = km;
            this.min = min;
        }
    }
    public class CabInvoice
    {

        const double RATE_PER_KM = 10,
                     RATE_PER_MIN = 1,
                     MIN_FARE=5;
        public double Fare(double km, double min)
        {
            double CalculatedFare = km * RATE_PER_KM + min * RATE_PER_MIN;

            if(CalculatedFare >= MIN_FARE)
            {
                return CalculatedFare;
            }
            return MIN_FARE;
        }
        
        public double MultiRideFare(List<Rides> rides)
        {
            double total = 0;
            foreach(var ride in rides)
            {
                total+=Fare(ride.km,ride.min);
            }
            return total;
        }
    }
}
