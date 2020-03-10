using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer
{
    /*
     *  "ProcessHistories": [
            {
                "Date": "20.01.2020 17:33:17",
                "ProcessHistoryType": "PASSENGERUPDATED",
                "Explanation": "Yolcu(lar) eklendi",
                "Username": "MTY",
                "ShoppingCartId": "59042081-2e49-49b0-bc5e-6ae85d26de84",
                "InsertedAt": "20.01.2020 17:33:17",
                "UpdatedAt": "20.01.2020 17:33:17"
            }
        ] 
     */

    public class ProcessHistory
    {
        public String Date;
        public String ProcessHistoryType;
        public String Explanation;
        public String Username;
        public String ShoppingCartId;
        public String InsertedAt;
        public String UpdatedAt;

        public ProcessHistory(string date, string processHistoryType, string explanation, string username, string shoppingCartId, string ınsertedAt, string updatedAt)
        {
            Date = date;
            ProcessHistoryType = processHistoryType;
            Explanation = explanation;
            Username = username;
            ShoppingCartId = shoppingCartId;
            InsertedAt = ınsertedAt;
            UpdatedAt = updatedAt;
        }
    }
}
