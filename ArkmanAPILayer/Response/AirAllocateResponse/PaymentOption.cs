using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer
{
    public class PaymentOption
    {
        public InstallmentOption[] InstallmentOptions;
        public AvailableBank[] AvailableBanks;

        public PaymentOption(InstallmentOption[] ınstallmentOptions, AvailableBank[] availableBanks)
        {
            InstallmentOptions = ınstallmentOptions;
            AvailableBanks = availableBanks;
        }
    }
}
