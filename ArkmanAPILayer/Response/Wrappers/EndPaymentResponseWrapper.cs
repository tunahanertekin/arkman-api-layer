using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer.Response.Wrappers
{
    public class EndPaymentResponseWrapper
    {
        public ShoppingCart ShoppingCart;
        public Boolean HasError;
        public ServiceError ServiceError;

        public EndPaymentResponseWrapper(ShoppingCart shoppingCart, bool hasError, ServiceError serviceError)
        {
            ShoppingCart = shoppingCart;
            HasError = hasError;
            ServiceError = serviceError;
        }
    }
}
