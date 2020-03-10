using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer
{
    /*
     * "OriginDestinationOptions": [
            {
              "PricingInfo": {
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
              "FlightSegments": [
                {
                  "ProductId": "e3bf18ea-3d03-474f-85d5-f80e1a89c2e0",
                  "ResBookDesigQuantity": "9",
                  "Provider": "TurkishAirlines",
                  "BookingClass": "V",
                  "CabinType": "Economy",
                  "DirectionInd": 0,
                  "IsConnectedPreviousSegment": false,
                  "IsConnected": false,
                  "FlightNumber": "TK2192",
                  "JourneyDuration": "1H20M",
                  "JourneyDurationInMinute": 0,
                  "DepartureAirportCode": "IST",
                  "DepartureAirportName": "Ataturk",
                  "DepartureCityName": "Istanbul",
                  "DepartureCountryName": "Turkey",
                  "DepartureDate": "15.09.2017",
                  "DepartureTime": "02:20",
                  "ArrivalAirportCode": "ESB",
                  "ArrivalAirportName": "Esenboga",
                  "ArrivalCityName": "Ankara",
                  "ArrivalCountryName": "Turkey",
                  "ArrivalDate": "15.09.2017",
                  "ArrivalTime": "03:40",
                  "EquipmentType": "",
                  "MarkettingAirline": "TK",
                  "OperatingAirline": "TK",
                  "IsReservable": false,
                  "IsEticket": true
                }
              ]
            }
         ],
     */

    public class OriginDestinationOption
    {
        public String Id;
        public PricingInfo PricingInfo;
        public FlightSegment[] FlightSegments;

        public OriginDestinationOption(string ıd, PricingInfo pricingInfo, FlightSegment[] flightSegments)
        {
            Id = ıd;
            PricingInfo = pricingInfo;
            FlightSegments = flightSegments;
        }
    }
}
