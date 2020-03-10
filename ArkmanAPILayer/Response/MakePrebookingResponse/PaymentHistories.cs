using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer
{
    /*
     *    "PaymentHistories": [
            {
                "RequestId": "ca55e247-7913-40ee-a4c1-bf563abb4537",
                "PaymentChannel": 0,
                "Date": "21.01.2020 10:37:30",
                "PaymentHistoryType": "CASH",
                "Amount": 293.99,
                "CreditCardNumber": "",
                "BankName": "",
                "PosCode": "",
                "Installment": "",
                "InstallmentId": "",
                "Explanation": "Peşin ödeme",
                "AuthCode": null,
                "TransId": null,
                "Username": "METAY",
                "Currency": "TRY",
                "Voided": false,
                "ShoppingCartId": "400844cc-5554-48cc-8153-220ee6f2c41c",
                "InsertedAt": "21.01.2020 10:37:30",
                "UpdatedAt": "21.01.2020 10:37:30"
            }
        ]
     */

    public class PaymentHistory
    {
        public String RequestId;
        public int PaymentChannel;
        public String Date;
        public String PaymentHistoryType;
        public double Amount;
        public String CreditCardNumber;
        public String BankName;
        public String PosCode;
        public String Installment;
        public String InstallmentId;
        public String Explanation;
        public String AuthCode;
        public String TransId;
        public String Username;
        public String Currency;
        public Boolean Voided;
        public String ShoppingCartId;
        public String InsertedAt;
        public String UpdatedAt;

        public PaymentHistory(string requestId, int paymentChannel, string date, string paymentHistoryType, double amount, string creditCardNumber, string bankName, string posCode, string ınstallment, string ınstallmentId, string explanation, string authCode, string transId, string username, string currency, bool voided, string shoppingCartId, string ınsertedAt, string updatedAt)
        {
            RequestId = requestId;
            PaymentChannel = paymentChannel;
            Date = date;
            PaymentHistoryType = paymentHistoryType;
            Amount = amount;
            CreditCardNumber = creditCardNumber;
            BankName = bankName;
            PosCode = posCode;
            Installment = ınstallment;
            InstallmentId = ınstallmentId;
            Explanation = explanation;
            AuthCode = authCode;
            TransId = transId;
            Username = username;
            Currency = currency;
            Voided = voided;
            ShoppingCartId = shoppingCartId;
            InsertedAt = ınsertedAt;
            UpdatedAt = updatedAt;
        }
    }
}
