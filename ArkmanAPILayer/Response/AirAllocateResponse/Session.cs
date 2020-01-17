using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer
{
    public class Session
    {
        public String SessionId;
        public String SessionToken;

        public Session(string sessionId, string sessionToken)
        {
            SessionId = sessionId;
            SessionToken = sessionToken;
        }
    }
}
