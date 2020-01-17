using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer
{
    /*
     *    "FlightSegments": [
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
              "DepartureDateTime": "**extra**",
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
              "MarkettingAirlineName": "Turkish Airlines",
              "OperatingAirline": "TK",
              "OperatingAirlineName": "Turkish Airlines",
              "IsReservable": false,
              "IsEticket": true
            }
          ]
     */

    public class FlightSegment
    {
        public String ProductId;
        public String ResBookDesigQuantity;
        public String Provider;
        public String BookingClass;
        public String CabinType;
        public int DirectionInd;
        public Boolean IsConnectedPreviousSegment;
        public Boolean IsConnected;
        public String FlightNumber;
        public String JourneyDuration;
        public int JourneyDurationInMinute;
        public String DepartureAirportCode;
        public String DepartureAirportName;
        public String DepartureCityName;
        public String DepartureCountryName;
        public String DepartureDateTime;
        public String DepartureDate;
        public String DepartureTime;
        public String ArrivalAirportCode;
        public String ArrivalAirportName;
        public String ArrivalCityName;
        public String ArrivalCountryName;
        public String ArrivalDate;
        public String ArrivalTime;
        public String EquipmentType;
        public String MarkettingAirline;
        public String MarkettingAirlineName;
        public String OperatingAirline;
        public String OperatingAirlineName;
        public Boolean IsReservable;
        public Boolean IsEticket;

        public FlightSegment(string productId, string resBookDesigQuantity, string provider, string bookingClass, string cabinType, int directionInd, bool ısConnectedPreviousSegment, bool ısConnected, string flightNumber, string journeyDuration, int journeyDurationInMinute, string departureAirportCode, string departureAirportName, string departureCityName, string departureCountryName, string departureDateTime, string departureDate, string departureTime, string arrivalAirportCode, string arrivalAirportName, string arrivalCityName, string arrivalCountryName, string arrivalDate, string arrivalTime, string equipmentType, string markettingAirline, string markettingAirlineName, string operatingAirline, string operatingAirlineName, bool ısReservable, bool ısEticket)
        {
            ProductId = productId;
            ResBookDesigQuantity = resBookDesigQuantity;
            Provider = provider;
            BookingClass = bookingClass;
            CabinType = cabinType;
            DirectionInd = directionInd;
            IsConnectedPreviousSegment = ısConnectedPreviousSegment;
            IsConnected = ısConnected;
            FlightNumber = flightNumber;
            JourneyDuration = journeyDuration;
            JourneyDurationInMinute = journeyDurationInMinute;
            DepartureAirportCode = departureAirportCode;
            DepartureAirportName = departureAirportName;
            DepartureCityName = departureCityName;
            DepartureCountryName = departureCountryName;
            DepartureDateTime = departureDateTime;
            DepartureDate = departureDate;
            DepartureTime = departureTime;
            ArrivalAirportCode = arrivalAirportCode;
            ArrivalAirportName = arrivalAirportName;
            ArrivalCityName = arrivalCityName;
            ArrivalCountryName = arrivalCountryName;
            ArrivalDate = arrivalDate;
            ArrivalTime = arrivalTime;
            EquipmentType = equipmentType;
            MarkettingAirline = markettingAirline;
            MarkettingAirlineName = markettingAirlineName;
            OperatingAirline = operatingAirline;
            OperatingAirlineName = operatingAirlineName;
            IsReservable = ısReservable;
            IsEticket = ısEticket;
        }
    }
}
