using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer
{
    /*
     *  "Destination": {
          "AirportCode": "ESB",
          "IsCity": false
         }
     */
    public class Destination
    {
        public String AirportCode;
        public Boolean IsCity;

        public Destination(string airportCode, bool ısCity)
        {
            AirportCode = airportCode;
            IsCity = ısCity;
        }
    }
}
