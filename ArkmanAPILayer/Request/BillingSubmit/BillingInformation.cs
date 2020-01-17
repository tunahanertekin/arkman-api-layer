using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer
{
    /*
     *"BillingInformation": {
        "IfCompany": false,
        "BillingName": "Barbaros Kurt",
        "TaxNo": "500600800200",
        "TaxOffice": "",
        "Address": "Arkman Yazılım",
        "City": "",
        "District": "",
        "ZipCode": "",
        "CountryCode": ""
       } 
     */

    public class BillingInformation
    {
        public Boolean IfCompany;
        public String BillingName;
        public String TaxNo;
        public String TaxOffice;
        public String Address;
        public String City;
        public String District;
        public String ZipCode;
        public String CountryCode;

        public BillingInformation(bool ıfCompany, string billingName, string taxNo, string taxOffice, string address, string city, string district, string zipCode, string countryCode)
        {
            IfCompany = ıfCompany;
            BillingName = billingName;
            TaxNo = taxNo;
            TaxOffice = taxOffice;
            Address = address;
            City = city;
            District = district;
            ZipCode = zipCode;
            CountryCode = countryCode;
        }
    }
}
