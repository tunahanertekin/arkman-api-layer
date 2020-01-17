using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer.Response.Wrappers
{
    public class AirAllocateResponseWrapper
    {
        public ShoppingCart ShoppingCart;
        public Boolean HasError;

        public AirAllocateResponseWrapper(ShoppingCart shoppingCart, bool hasError)
        {
            ShoppingCart = shoppingCart;
            HasError = hasError;
        }
    }
}
