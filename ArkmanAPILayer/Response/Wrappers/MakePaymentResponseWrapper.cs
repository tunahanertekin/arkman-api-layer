using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer.Response.Wrappers
{
    public class MakePaymentResponseWrapper
    {
        public ShoppingCart ShoppingCart;
        public Boolean HasError;

        public MakePaymentResponseWrapper(ShoppingCart shoppingCart, bool hasError)
        {
            ShoppingCart = shoppingCart;
            HasError = hasError;
        }
    }
}
