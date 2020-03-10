using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer
{
    /*
     *      "ErrorFlags": {
                "AuthenticationError": false,
                "AuthorizationError": false,
                "InputFormatError": false,
                "InputLogicError": false,
                "UnknownError": false,
                "SystemError": false,
                "BookingProviderError": false,
                "DatabaseError": false,
                "PaymentGateError": true
            } 
     */

    public class ErrorFlags
    {
        public Boolean AuthenticationError;
        public Boolean AuthorizationError;
        public Boolean InputFormatError;
        public Boolean InputLogicError;
        public Boolean UnknownError;
        public Boolean SystemError;
        public Boolean BookingProviderError;
        public Boolean DatabaseError;
        public Boolean PaymentGateError;

        public ErrorFlags(bool authenticationError, bool authorizationError, bool ınputFormatError, bool ınputLogicError, bool unknownError, bool systemError, bool bookingProviderError, bool databaseError, bool paymentGateError)
        {
            AuthenticationError = authenticationError;
            AuthorizationError = authorizationError;
            InputFormatError = ınputFormatError;
            InputLogicError = ınputLogicError;
            UnknownError = unknownError;
            SystemError = systemError;
            BookingProviderError = bookingProviderError;
            DatabaseError = databaseError;
            PaymentGateError = paymentGateError;
        }
    }
}
