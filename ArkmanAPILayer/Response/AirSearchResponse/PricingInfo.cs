using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer
{
    /*
     *  "PricingInfo": {
            "FareReference": "ER",
            "FareBreakdowns": [
              {
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
            ],
            "BaseFare": 93,
            "TotalTax": 37.99,
            "TotalMarkupFare": 0,
            "TotalServiceFee": 10,
            "TotalFare": 140.99,
            "Currency": "TRY",
            "FareInfoType": "Promo"
        }, 
     */

    public class PricingInfo
    {
        public String FareReference;
        public FareBreakdown[] FareBreakdowns;
        public double BaseFare;
        public double TotalTax;
        public double TotalMarkupFare;
        public double TotalServiceFee;
        public double TotalFare;
        public String Currency;
        public String FareInfoType;

        public PricingInfo(string fareReference, FareBreakdown[] fareBreakdowns, double baseFare, double totalTax, double totalMarkupFare, double totalServiceFee, double totalFare, string currency, string fareInfoType)
        {
            FareReference = fareReference;
            FareBreakdowns = fareBreakdowns;
            BaseFare = baseFare;
            TotalTax = totalTax;
            TotalMarkupFare = totalMarkupFare;
            TotalServiceFee = totalServiceFee;
            TotalFare = totalFare;
            Currency = currency;
            FareInfoType = fareInfoType;
        }
    }
}
