using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer
{
    public class PaxReference
    {
        public String PaxCode;
        public String PaxReferanceId;

        public PaxReference(string paxCode, string paxReferanceId)
        {
            PaxCode = paxCode;
            PaxReferanceId = paxReferanceId;
        }
    }
}
