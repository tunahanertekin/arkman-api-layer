using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer.Response.Wrappers
{
    public class MakePrebookingResponseWrapper
    {
        public ShoppingCart ShoppingCart;
        public Boolean HasError;

        public MakePrebookingResponseWrapper(ShoppingCart shoppingCart, bool hasError)
        {
            ShoppingCart = shoppingCart;
            HasError = hasError;
        }
    }
}
