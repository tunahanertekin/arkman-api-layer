using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer
{
    /*
     * "AirSearchPaxItems": [
        {
          "PaxCode": "ADT",
          "PaxCount": 1
        }
       ]
     */
   
    public class AirSearchPaxItem
    {
        public String PaxCode;
        public int PaxCount;

        public AirSearchPaxItem(string paxCode, int paxCount)
        {
            PaxCode = paxCode;
            PaxCount = paxCount;
        }
    }
}
