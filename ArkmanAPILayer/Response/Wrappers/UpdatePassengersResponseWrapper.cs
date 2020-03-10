using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer.Response.Wrappers
{
    public class UpdatePassengersResponseWrapper
    {
        public ShoppingCart ShoppingCart;
        public Boolean HasError;

        public UpdatePassengersResponseWrapper(ShoppingCart shoppingCart, bool hasError)
        {
            ShoppingCart = shoppingCart;
            HasError = hasError;
        }
    }
}
