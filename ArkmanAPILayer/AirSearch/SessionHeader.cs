using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer
{

    /*
     * SessionHeader": {
        "SessionId": "cxLuvAhbFdmDXFf47",
        "SessionToken": "0e7ae860-afe5-41d3-a5cf-3202fab22e73"
       }
     */
   
    public class SessionHeader
    {
        public String SessionId;
        public String SessionToken;

        public SessionHeader(string sessionId, string sessionToken)
        {
            SessionId = sessionId;
            SessionToken = sessionToken;
        }
    }
}
