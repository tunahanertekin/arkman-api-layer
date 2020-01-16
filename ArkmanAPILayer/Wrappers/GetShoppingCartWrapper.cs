using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer.Wrappers
{
    public class GetShoppingCartWrapper : Wrapper
    {
        public SessionHeader SessionHeader;
        public String ShoppingCartId;

        public GetShoppingCartWrapper(SessionHeader sessionHeader, string shoppingCartId)
        {
            SessionHeader = sessionHeader;
            ShoppingCartId = shoppingCartId;
        }
    }
}
