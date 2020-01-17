using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer.Wrappers
{
    public class BillingSubmitWrapper : Wrapper
    {
        public SessionHeader SessionHeader;
        public String ShoppingCartId;
        public BillingInformation BillingInformation;

        public BillingSubmitWrapper(SessionHeader sessionHeader, string shoppingCartId, BillingInformation billingInformation)
        {
            SessionHeader = sessionHeader;
            ShoppingCartId = shoppingCartId;
            BillingInformation = billingInformation;
        }
    }
}
