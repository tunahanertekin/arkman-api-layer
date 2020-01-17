using System;
using System.Collections.Generic;
using System.Text;

using ArkmanAPILayer;

namespace ArkmanAPILayer.Response.Wrappers
{
    public class AirSearchResponseWrapper
    {
        public OriginDestinationOption[] OriginDestinationOptions;
        public int DirectionInd;
        public Boolean IsInternational;
        public Boolean HasError;

        public AirSearchResponseWrapper(OriginDestinationOption[] originDestinationOptions, int directionInd, bool ısInternational, bool hasError)
        {
            OriginDestinationOptions = originDestinationOptions;
            DirectionInd = directionInd;
            IsInternational = ısInternational;
            HasError = hasError;
        }
    }
}
