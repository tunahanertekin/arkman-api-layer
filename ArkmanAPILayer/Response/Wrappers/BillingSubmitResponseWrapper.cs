using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer.Response.Wrappers
{
    public class BillingSubmitResponseWrapper
    {
        public ShoppingCart ShoppingCart;
        public Boolean HasError;
        public ServiceError ServiceError;

        public BillingSubmitResponseWrapper(ShoppingCart shoppingCart, bool hasError, ServiceError serviceError)
        {
            ShoppingCart = shoppingCart;
            HasError = hasError;
            ServiceError = serviceError;
        }
    }
}
