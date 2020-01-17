using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer
{
    public class ShoppingCart
    {
        public String Id;
        public Session Session;
        public AirBooking[] AirBookings;
        public String[] AirProviders;
        public Boolean IsFinalized;
        public Boolean IsBilled;
        public Boolean IsPassengersLocked;
        public String CreatedAt;
        public String UpdatedAt;
        public PaymentOption PaymentOption;
        public double RemainingTotal;
        public String[] AllocatedProductIds;
        public int EArchiveWebAddress;
        public Boolean ContinueWithoutAirReservation;
        public int PaymentChannel;
        public String ProviderType;
        public Boolean HasVoid;
        public Boolean HasRefund;

        public ShoppingCart(string ıd, Session session, AirBooking[] airBookings, string[] airProviders, bool ısFinalized, bool ısBilled, bool ısPassengersLocked, string createdAt, string updatedAt, PaymentOption paymentOption, double remainingTotal, string[] allocatedProductIds, int eArchiveWebAddress, bool continueWithoutAirReservation, int paymentChannel, string providerType, bool hasVoid, bool hasRefund)
        {
            Id = ıd;
            Session = session;
            AirBookings = airBookings;
            AirProviders = airProviders;
            IsFinalized = ısFinalized;
            IsBilled = ısBilled;
            IsPassengersLocked = ısPassengersLocked;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            PaymentOption = paymentOption;
            RemainingTotal = remainingTotal;
            AllocatedProductIds = allocatedProductIds;
            EArchiveWebAddress = eArchiveWebAddress;
            ContinueWithoutAirReservation = continueWithoutAirReservation;
            PaymentChannel = paymentChannel;
            ProviderType = providerType;
            HasVoid = hasVoid;
            HasRefund = hasRefund;
        }
    }
}
