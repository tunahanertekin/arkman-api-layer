using System;
using System.Collections.Generic;
using System.Text;

using ArkmanAPILayer;

namespace ArkmanAPILayer.Response.Wrappers
{
    public class AirSearchResponseWrapper
    {
        public SessionHeader SessionHeader;
        public OriginDestinationOption[] OriginDestinationOptions;
        public int DirectionInd;
        public Boolean IsInternational;
        public Boolean HasError;

        public AirSearchResponseWrapper(SessionHeader sessionHeader, OriginDestinationOption[] originDestinationOptions, int directionInd, bool ısInternational, bool hasError)
        {
            SessionHeader = sessionHeader;
            OriginDestinationOptions = originDestinationOptions;
            DirectionInd = directionInd;
            IsInternational = ısInternational;
            HasError = hasError;
        }
    }
}
