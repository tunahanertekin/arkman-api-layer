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
        public Passenger[] Passengers;
        public PaymentOption PaymentOption;
        public BillingInformation BillingInformation;
        public Contact Contact;
        public ShoppingSummary ShoppingSummary;
        public double RemainingTotal;
        public String[] AllocatedProductIds;
        public PaymentHistory[] PaymentHistories;
        public ProcessHistory[] ProcessHistories;
        public String JobId;
        public int EArchiveWebAddress;
        public Boolean ContinueWithoutAirReservation;
        public int PaymentChannel;
        public String ProviderType;
        public Boolean HasVoid;
        public Boolean HasRefund;

        public ShoppingCart(string ıd, Session session, AirBooking[] airBookings, string[] airProviders, bool ısFinalized, bool ısBilled, bool ısPassengersLocked, string createdAt, string updatedAt, Passenger[] passengers, PaymentOption paymentOption, BillingInformation billingInformation, Contact contact, ShoppingSummary shoppingSummary, double remainingTotal, string[] allocatedProductIds, PaymentHistory[] paymentHistories, ProcessHistory[] processHistories, string jobId, int eArchiveWebAddress, bool continueWithoutAirReservation, int paymentChannel, string providerType, bool hasVoid, bool hasRefund)
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
            Passengers = passengers;
            PaymentOption = paymentOption;
            BillingInformation = billingInformation;
            Contact = contact;
            ShoppingSummary = shoppingSummary;
            RemainingTotal = remainingTotal;
            AllocatedProductIds = allocatedProductIds;
            PaymentHistories = paymentHistories;
            ProcessHistories = processHistories;
            JobId = jobId;
            EArchiveWebAddress = eArchiveWebAddress;
            ContinueWithoutAirReservation = continueWithoutAirReservation;
            PaymentChannel = paymentChannel;
            ProviderType = providerType;
            HasVoid = hasVoid;
            HasRefund = hasRefund;
        }
    }
}
