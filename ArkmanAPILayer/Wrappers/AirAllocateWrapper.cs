using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer.Wrappers
{
    public class AirAllocateWrapper : Wrapper
    {
        public SessionHeader SessionHeader;
        public AllocateItem[] AllocateItems;

        public AirAllocateWrapper(SessionHeader sessionHeader, AllocateItem[] allocateItems)
        {
            SessionHeader = sessionHeader;
            AllocateItems = allocateItems;
        }
    }
}
