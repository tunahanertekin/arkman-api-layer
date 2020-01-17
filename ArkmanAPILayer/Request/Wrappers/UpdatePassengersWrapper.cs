using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer.Wrappers
{
    public class UpdatePassengersWrapper : Wrapper
    {
        public SessionHeader SessionHeader;
        public String CorporatePin;
        public String ShoppingCartId;
        public Contact Contact;
        public Passenger[] Passengers;

        public UpdatePassengersWrapper(SessionHeader sessionHeader, string corporatePin, string shoppingCartId, Contact contact, Passenger[] passengers)
        {
            SessionHeader = sessionHeader;
            CorporatePin = corporatePin;
            ShoppingCartId = shoppingCartId;
            Contact = contact;
            Passengers = passengers;
        }
    }
}
