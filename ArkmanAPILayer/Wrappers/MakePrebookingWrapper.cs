using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer.Wrappers
{
    public class MakePrebookingWrapper : Wrapper
    {
        public SessionHeader SessionHeader;
        public String ShoppingCartId;

        public MakePrebookingWrapper(SessionHeader sessionHeader, string shoppingCartId)
        {
            SessionHeader = sessionHeader;
            ShoppingCartId = shoppingCartId;
        }
    }
}
