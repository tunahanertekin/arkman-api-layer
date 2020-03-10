using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer.Wrappers
{
    public class EndPaymentWrapper : Wrapper
    {
        public SessionHeader SessionHeader;
        public String ShoppingCartId;
        public String PaymentType;
        public double Amount;
        public String PayableBank;
        public PaymentForm PaymentForm;

        public EndPaymentWrapper(SessionHeader sessionHeader, string shoppingCartId, string paymentType, double amount, string payableBank, PaymentForm paymentForm)
        {
            SessionHeader = sessionHeader;
            ShoppingCartId = shoppingCartId;
            PaymentType = paymentType;
            Amount = amount;
            PayableBank = payableBank;
            PaymentForm = paymentForm;
        }
    }
}
