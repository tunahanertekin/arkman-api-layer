using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer
{
    /*
     * "AirSearchSegments": [
        {
          "SequenceNo": 1,
          "DepartureDay": "2020.01.15",
          "Origin": {
            "AirportCode": "IST",
            "IsCity": false
          },
          "Destination": {
            "AirportCode": "ESB",
            "IsCity": false
          }
        }
       ]
     */

    public class AirSearchSegment
    {
        public int SequenceNo;
        public String DepartureDay;
        public Origin Origin;
        public Destination Destination;

        public AirSearchSegment(int sequenceNo, string departureDay, Origin origin, Destination destination)
        {
            SequenceNo = sequenceNo;
            DepartureDay = departureDay;
            Origin = origin;
            Destination = destination;
        }
    }
}
