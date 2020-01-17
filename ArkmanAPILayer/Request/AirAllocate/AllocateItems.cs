using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer
{
    public class AllocateItem
    {
        public String ProductId;
        public int MarkupFare;

        public AllocateItem(string productId, int markupFare)
        {
            ProductId = productId;
            MarkupFare = markupFare;
        }
    }
}
