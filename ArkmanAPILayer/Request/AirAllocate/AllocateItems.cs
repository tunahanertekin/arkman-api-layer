using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer
{
    public class AllocateItem
    {
        public String ProductId;
        public String PriceId;
        public int MarkupFare;

        public AllocateItem(string productId, string priceId, int markupFare)
        {
            ProductId = productId;
            PriceId = priceId;
            MarkupFare = markupFare;
        }
    }
}
