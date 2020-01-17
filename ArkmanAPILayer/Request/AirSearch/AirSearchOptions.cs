using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer
{
    /*
     * "AirSearchOptions": {
        "FlightType": "OW",
        "CabinType": "Economy",
        "RefundableType": "AllFlights",
        "Currency": "TRY",
        "DirectFlightsOnly": false,
        "AvailableFlightsOnly": true,
        "FareDisplayType": "Lowest"
       }
     */

    public class AirSearchOptions
    {
        public String FlightType;
        public String CabinType;
        public String RefundableType;
        public String Currency;
        public Boolean DirectFlightsOnly;
        public Boolean AvailableFlightsOnly;
        public String FareDisplayType;

        
        public AirSearchOptions(string flightType, string cabinType, string refundableType, string currency, bool directFlightsOnly, bool availableFlightsOnly, string fareDisplayType)
        {
            FlightType = flightType;
            CabinType = cabinType;
            RefundableType = refundableType;
            Currency = currency;
            DirectFlightsOnly = directFlightsOnly;
            AvailableFlightsOnly = availableFlightsOnly;
            FareDisplayType = fareDisplayType;
        }
    }
}
