﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class EnhancedInvoice
    {
        public readonly double totalFare = 0,
                               totalRides = 0,
                               AvgFare;
        public EnhancedInvoice(double totalFare, double totalRides)
        {
            this.totalFare = totalFare;
            this.totalRides = totalRides;
            this.AvgFare = totalFare / totalRides;
            
        }
    }
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
        
        public EnhancedInvoice MultiRideFare(List<Rides> rides)
        {
            double totalFare = 0;
            foreach(var ride in rides)
            {
                totalFare += Fare(ride.km,ride.min);
            }
            EnhancedInvoice EnIn = new EnhancedInvoice(totalFare, rides.Count);
            return EnIn;
        }
    }
}
