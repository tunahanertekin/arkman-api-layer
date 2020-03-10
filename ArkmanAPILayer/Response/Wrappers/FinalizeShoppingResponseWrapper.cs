using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer.Response.Wrappers
{
    public class FinalizeShoppingResponseWrapper
    {
        public ShoppingCart ShoppingCart;
        public Boolean HasError;
        public ServiceError ServiceError;

        public FinalizeShoppingResponseWrapper(ShoppingCart shoppingCart, bool hasError, ServiceError serviceError)
        {
            ShoppingCart = shoppingCart;
            HasError = hasError;
            ServiceError = serviceError;
        }
    }
}
