using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer.Response.Wrappers
{
    public class LoginResponseWrapper
    {
        public String SessionId;
        public String SessionToken;
        public Boolean IsTest;

        public LoginResponseWrapper(string sessionId, string sessionToken, bool ısTest)
        {
            SessionId = sessionId;
            SessionToken = sessionToken;
            IsTest = ısTest;
        }
    }
}
