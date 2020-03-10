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
        public double Amount;

        public MakePaymentWrapper(SessionHeader sessionHeader, string shoppingCartId, string paymentType, double amount)
        {
            SessionHeader = sessionHeader;
            ShoppingCartId = shoppingCartId;
            PaymentType = paymentType;
            Amount = amount;
        }
    }
}
