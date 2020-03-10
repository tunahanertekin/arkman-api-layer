using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer
{
    /*
     * "InstallmentOptions": [
            {
              "InstallmentOptionId": "b8fbfc6b-e45a-4050-a737-8f28b108e7eb",
              "BankName": "TurkiyeFinans",
              "Currency": "TRY",
              "InstallmentCount": 1,
              "MontlyPayment": 170.58,
              "Program": "",
              "ImagePath": null,
              "PosCode": "TUR",
              "RateOfInterest": 0.9,
              "AmountOfInterest": 0.9,
              "RemainingSum": 169.06,
              "SubTotal": 170.58,
              "VirtualPosId": 0
            }
        ]
     */

    public class InstallmentOption
    {
        public String InstallmentOptionId;
        public String BankName;
        public String Currency;
        public int InstallmentCount;
        public double MontlyPayment;
        public String Program;
        public String ImagePath;
        public String PosCode;
        public double RateOfInterest;
        public double AmountOfInterest;
        public double RemainingSum;
        public double SubTotal;
        public int VirtualPosId;

        public InstallmentOption(string ınstallmentOptionId, string bankName, string currency, int ınstallmentCount, double montlyPayment, string program, string ımagePath, string posCode, double rateOfInterest, double amountOfInterest, double remainingSum, double subTotal, int virtualPosId)
        {
            InstallmentOptionId = ınstallmentOptionId;
            BankName = bankName;
            Currency = currency;
            InstallmentCount = ınstallmentCount;
            MontlyPayment = montlyPayment;
            Program = program;
            ImagePath = ımagePath;
            PosCode = posCode;
            RateOfInterest = rateOfInterest;
            AmountOfInterest = amountOfInterest;
            RemainingSum = remainingSum;
            SubTotal = subTotal;
            VirtualPosId = virtualPosId;
        }
    }
}
