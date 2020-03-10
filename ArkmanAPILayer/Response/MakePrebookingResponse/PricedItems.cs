using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer
{
    /*
     *      "PricedItems": [
                {
                    "InCart": true,
                    "ProviderType": "Air",
                    "Total": 293.99
                },
                {
                    "InCart": true,
                    "ProviderType": "Air",
                    "Total": 293.99
                }
            ] 
     */

    public class PricedItem
    {
        public Boolean InCart;
        public String ProviderType;
        public double Total;

        public PricedItem(bool ınCart, string providerType, double total)
        {
            InCart = ınCart;
            ProviderType = providerType;
            Total = total;
        }
    }
}
