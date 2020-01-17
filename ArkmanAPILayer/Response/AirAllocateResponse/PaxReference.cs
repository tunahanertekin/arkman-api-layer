using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer
{
    public class PaxReference
    {
        public String PaxCode;
        public String PaxReferenceId;

        public PaxReference(string paxCode, string paxReferenceId)
        {
            PaxCode = paxCode;
            PaxReferenceId = paxReferenceId;
        }
    }
}
