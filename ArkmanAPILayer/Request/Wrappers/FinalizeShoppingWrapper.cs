using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer.Wrappers
{
    public class FinalizeShoppingWrapper : Wrapper
    {
        public SessionHeader SessionHeader;
        public String ShoppingCartId;

        public FinalizeShoppingWrapper(SessionHeader sessionHeader, string shoppingCartId)
        {
            SessionHeader = sessionHeader;
            ShoppingCartId = shoppingCartId;
        }
    }
}
