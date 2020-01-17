using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer
{
    /*
     * {
        "PassengerTypeCode": "ADT",
        "PassengerTypeQuantity": 1,
        "CabinType": "Economy",
        "Currency": "TRY",
        "AvailableSeats": 9,
        "BaseFare": 93,
        "MarkupFare": 0,
        "ServiceFee": 10,
        "TotalFare": 140.99,
        "TotalTax": 37.99,
        "VQ": 10,
        "YR": 27.99
       }
     */
    public class FareBreakdown
    {
        public String PassengerTypeCode;
        public int PassengerTypeQuantity;
        public String CabinType;
        public String Currency;
        public int AvailableSeats;
        public double BaseFare;
        public double MarkupFare;
        public double ServiceFee;
        public double TotalFare;
        public double TotalTax;
        public double VQ;
        public double YR;

        public FareBreakdown(string passengerTypeCode, int passengerTypeQuantity, string cabinType, string currency, int availableSeats, double baseFare, double markupFare, double serviceFee, double totalFare, double totalTax, double vQ, double yR)
        {
            PassengerTypeCode = passengerTypeCode;
            PassengerTypeQuantity = passengerTypeQuantity;
            CabinType = cabinType;
            Currency = currency;
            AvailableSeats = availableSeats;
            BaseFare = baseFare;
            MarkupFare = markupFare;
            ServiceFee = serviceFee;
            TotalFare = totalFare;
            TotalTax = totalTax;
            VQ = vQ;
            YR = yR;
        }
    }
}
