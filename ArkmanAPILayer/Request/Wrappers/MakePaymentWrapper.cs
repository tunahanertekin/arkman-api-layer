using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer.Wrappers
{
    public class MakePaymentWrapper : Wrapper
    {
        public SessionHeader SessionHeader;
        public String ShoppingCartId;
        public String PaymentType;
        public int Amount;

        public MakePaymentWrapper(SessionHeader sessionHeader, string shoppingCartId, string paymentType, int amount)
        {
            SessionHeader = sessionHeader;
            ShoppingCartId = shoppingCartId;
            PaymentType = paymentType;
            Amount = amount;
        }
    }
}
