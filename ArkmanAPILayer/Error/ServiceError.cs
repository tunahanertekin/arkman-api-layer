using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer
{
    /*
     * "ServiceError": {
            "ErrorMessages": [
                "Ödeme daha önce yapılmış."
            ],
            "ErrorFlags": {
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
        } 
     */

    public class ServiceError
    {
        public String[] ErrorMessages;
        public ErrorFlags ErrorFlags;

        public ServiceError(string[] errorMessages, ErrorFlags errorFlags)
        {
            ErrorMessages = errorMessages;
            ErrorFlags = errorFlags;
        }
    }
}
