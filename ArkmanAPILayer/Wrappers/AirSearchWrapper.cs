using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer.Wrappers
{
    public class AirSearchWrapper : Wrapper
    {
        public SessionHeader SessionHeader;
        public AirSearchOptions AirSearchOptions;
        public AirSearchPaxItem[] AirSearchPaxItems;
        public AirSearchSegment[] AirSearchSegments;

        public AirSearchWrapper(SessionHeader sessionHeader, AirSearchOptions airSearchOptions, AirSearchPaxItem[] airSearchPaxItems, AirSearchSegment[] airSearchSegments)
        {
            SessionHeader = sessionHeader;
            AirSearchOptions = airSearchOptions;
            AirSearchPaxItems = airSearchPaxItems;
            AirSearchSegments = airSearchSegments;
        }
    }
}
