﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public class InvoiceSummary
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    { 
        //Variables.
        public double totalFare, avgFare;
        public int numOfRides;
        //Parameterized Constructor
        public InvoiceSummary(int numOfRides, double totalFare)
        {
            this.totalFare = totalFare;
            this.numOfRides = numOfRides;
            this.avgFare = totalFare / numOfRides;
        }
        /// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// <param name="obj">The <see cref="object" /> to compare with this instance.</param>
        ///   <c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is InvoiceSummary))
                return false;
            InvoiceSummary inputObj = (InvoiceSummary)obj;
            return this.numOfRides == inputObj.numOfRides && this.totalFare == inputObj.totalFare && this.avgFare == inputObj.avgFare;
        }
    }
}
