using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer
{
    /*
     *  "AirBookings": [
          {
            "BookingCode": "",
            "ControlNumber": "",
            "Status": "Allocated",
            "Provider": "TurkishAirlines",
            "PassengerBreakdowns": [
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
            ],
            "FlightSegments": [
              {
                "ProductId": "bfd9489f-3127-45da-8107-1e951201603f",
                "FareCode": "EF",
                "IsFromCombinableList": false,
                "IsFromCombinableOWCList": false,
                "ResBookDesigQuantity": "9",
                "Provider": "TurkishAirlines",
                "BookingClass": "P",
                "CabinType": "Economy",
                "DirectionInd": 0,
                "IsConnectedPreviousSegment": false,
                "IsConnected": false,
                "FlightNumber": "TK2152",
                "JourneyDuration": "1H10M",
                "JourneyDurationInMinute": 70,
                "DepartureAirportCode": "IST",
                "DepartureAirportName": "İstanbul Havalimanı",
                "DepartureCityName": "Istanbul",
                "DepartureCountryName": "Turkey",
                "DepartureDateTime": "2020-01-16T14:00:00+03:00",
                "DepartureDate": "16.01.2020",
                "DepartureTime": "14:00",
                "ArrivalAirportCode": "ESB",
                "ArrivalAirportName": "Esenboga",
                "ArrivalCityName": "Ankara",
                "ArrivalCountryName": "Turkey",
                "ArrivalDateTime": "2020-01-16T15:10:00+03:00",
                "ArrivalDate": "16.01.2020",
                "ArrivalTime": "15:10",
                "EquipmentType": "",
                "MarkettingAirline": "TK",
                "MarkettingAirlineName": "Turkish Airlines",
                "OperatingAirline": "TK",
                "OperatingAirlineName": "Turkish Airlines",
                "IsReservable": false,
                "IsEticket": true
              }
            ],
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
            "Currency": "TRY",
            "FareInfoType": "Promo"
          }
        ]
     */
    public class AirBooking
    {
        public String BookingCode;
        public String ControlNumber;
        public String CorporatePin;
        public String Status;
        public String Provider;
        public PassengerBreakdown[] PassengerBreakdowns;
        public FlightSegment[] FlightSegments;
        public AirBookingStatus AirBookingStatus;
        public AirBookingTimeTable AirBookingTimeTable;
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
        public String Currency;
        public String FareInfoType;

        public AirBooking(string bookingCode, string controlNumber, string corporatePin, string status, string provider, PassengerBreakdown[] passengerBreakdowns, FlightSegment[] flightSegments, double baseFare, double totalTax, double totalMarkupFare, double totalMarkupFareList, double totalServiceFee, double totalFare, double vQ, double yR, double cF, double tR, double vAT, string currency, string fareInfoType)
        {
            BookingCode = bookingCode;
            ControlNumber = controlNumber;
            CorporatePin = corporatePin;
            Status = status;
            Provider = provider;
            PassengerBreakdowns = passengerBreakdowns;
            FlightSegments = flightSegments;
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
            Currency = currency;
            FareInfoType = fareInfoType;
        }
    }
}
