using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer
{
    /*
     * "PaymentForm": {
        "CardHolder": "BARBAROS KURT",
        "CardNumber": "1111222233334444",
        "CardType": "MasterCard",
        "Cvv": "228",
        "ExpirationYear": "18",
        "ExpirationMonth": "05",
        "ExtraAmount": 0,
        "InstallmentId":  "cf812d73-6304-4747-8ef6-795e51533bc3",
        "InstallmentCount": 0,
        "Currency": "TRY",
        "ReturnUrl": "http://address.com/Finalize?ShopCartId=11a43c18-9de9-4adb-a31f-cd654afe55fe"
       }
     */

    public class PaymentForm
    {
        public String CardHolder;
        public String CardNumber;
        public String CardType;
        public String Cvv;
        public String ExpirationYear;
        public String ExpirationMonth;
        public double ExtraAmount;
        public String InstallmentId;
        public int InstallmentCount;
        public String Currency;
        public String ReturnUrl;

        public PaymentForm(string cardHolder, string cardNumber, string cardType, string cvv, string expirationYear, string expirationMonth, double extraAmount, string ınstallmentId, int ınstallmentCount, string currency, string returnUrl)
        {
            CardHolder = cardHolder;
            CardNumber = cardNumber;
            CardType = cardType;
            Cvv = cvv;
            ExpirationYear = expirationYear;
            ExpirationMonth = expirationMonth;
            ExtraAmount = extraAmount;
            InstallmentId = ınstallmentId;
            InstallmentCount = ınstallmentCount;
            Currency = currency;
            ReturnUrl = returnUrl;
        }
    }
}
