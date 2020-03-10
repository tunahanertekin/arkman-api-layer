using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer
{
    /*
     *"ShoppingSummary": {
            "GrandTotal": 587.98,
            "Paid": true,
            "PricedItems": [
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
        } 
     */

    public class ShoppingSummary
    {
        public double GrandTotal;
        public Boolean Paid;
        public PricedItem[] PricedItems;

        public ShoppingSummary(double grandTotal, bool paid, PricedItem[] pricedItems)
        {
            GrandTotal = grandTotal;
            Paid = paid;
            PricedItems = pricedItems;
        }
    }
}
