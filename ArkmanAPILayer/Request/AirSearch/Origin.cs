using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer
{
    /*
     * "Origin": {
         "AirportCode": "IST",
         "IsCity": false
        }
     */
    public class Origin
    {
        public String AirportCode;
        public Boolean IsCity;

        public Origin(string airportCode, bool ısCity)
        {
            AirportCode = airportCode;
            IsCity = ısCity;
        }
    }
}
