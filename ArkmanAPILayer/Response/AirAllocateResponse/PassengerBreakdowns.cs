using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer
{
    /*
     *  "PassengerBreakdowns": [
          {
            "PaxReference": {
                "PaxCode": "ADT",
                "PaxReferanceId": "976af051-8141-451d-adfc-1521ba2b5a53"
            },
            "TicketNumber": "",
            "IsExported": false,
            "IsVoid": false,
            "IsRefund": false,
            "BaggageAllowance": "15KG",
            "BaseFare": 144.06,
            "TotalTax": 20.0,
            "TotalMarkupFare": 0.0,
            "TotalMarkupFareList": 0.0,
            "TotalServiceFee": 5.0,
            "TotalFare": 169.06,
            "VQ": 20.0,
            "YR": 0.0,
            "CF": 0.0,
            "TR": 0.0,
            "VAT": 0.0,
            "FareInfoType": "Promo"
          }
        ] 
     */

    public class PassengerBreakdown
    {
        public PaxReference PaxReference;
        public String TicketNumber;
        public Boolean IsExported;
        public Boolean IsVoid;
        public Boolean IsRefund;
        public String BaggageAllowance;
        public double BaseFare;
        public double TotalTax;
        public double TotalMarkupFare;
        public double TotalMarkupFareList;
        public double TotalServiceFee;
        public double TotalFare;
        public double VQ;
        public double YR;
        public double CF;
        public double TR;
        public double VAT;
        public String FareInfoType;

        public PassengerBreakdown(PaxReference paxReference, string ticketNumber, bool ısExported, bool ısVoid, bool ısRefund, string baggageAllowance, double baseFare, double totalTax, double totalMarkupFare, double totalMarkupFareList, double totalServiceFee, double totalFare, double vQ, double yR, double cF, double tR, double vAT, string fareInfoType)
        {
            PaxReference = paxReference;
            TicketNumber = ticketNumber;
            IsExported = ısExported;
            IsVoid = ısVoid;
            IsRefund = ısRefund;
            BaggageAllowance = baggageAllowance;
            BaseFare = baseFare;
            TotalTax = totalTax;
            TotalMarkupFare = totalMarkupFare;
            TotalMarkupFareList = totalMarkupFareList;
            TotalServiceFee = totalServiceFee;
            TotalFare = totalFare;
            VQ = vQ;
            YR = yR;
            CF = cF;
            TR = tR;
            VAT = vAT;
            FareInfoType = fareInfoType;
        }
    }
}
