using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Net.Http;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using ArkmanAPILayer.Wrappers;

using RestSharp;

namespace ArkmanAPILayer
{
    public class APIResponse
    {
        public String responseStr;

        /// <summary>
        /// Yapılan post request'in response'unu String olarak tutan bir sınıf nesnesi.
        /// </summary>
        /// <param name="responseStr"></param>
        public APIResponse(String responseStr)
        {
            this.responseStr = responseStr;
        }
    }
    public class Arkman
    {
        public RestClient client = new RestClient("http://api.arkman.com.tr:1538");
        public RestRequest request;
        private void setRequest(String requestURL)
        {
            this.request = new RestRequest(requestURL);
        }
        

        /// <summary>
        /// Bütün post request'ler bu metottan yapılır. Girdi olarak tüm Wrapper sınıflarının üst sınıfı olan Wrapper sınıfının bir nesnesini alır. RestSharp ile post işlemi gerçekleşir.
        /// </summary>
        /// <param name="wrapper"></param>
        /// <returns></returns>
        private APIResponse MasterPostMethod(Wrapper wrapper)
        {
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(wrapper);

            var response = client.Post(request);
            var content = response.Content;

            JObject jsonResponse = JObject.Parse(content);
            String finalStr = JsonConvert.SerializeObject(jsonResponse);

            return new APIResponse(finalStr);
        }




        /*           SAMPLE REQUEST BODY
         *       {
         *          "Username": "test@met-aybilisim.com",
	     *          "Password": "metay123",
	     *          "IsTest": true
         *       }
         */


        /// <summary>
        /// "~/Login" endpoint'ine URL yönlendirilir. Metodun içinde MasterPostMethod çağrılır ve wrapper girdisindeki veriler buradan post edilir.
        /// </summary>
        /// <param name="wrapper"></param>
        /// <returns></returns>
        public APIResponse Login(LoginWrapper wrapper)
        {
            this.setRequest("/Login");
            return this.MasterPostMethod(wrapper);
        }




        /*
         * 
         *          SAMPLE REQUEST BODY (~/Air/Search)
         * 
                {
                  "SessionHeader": {
                    "SessionId": "cxLuvAhbFdmDXFf47",
                    "SessionToken": "0e7ae860-afe5-41d3-a5cf-3202fab22e73"
                  },
                  "AirSearchOptions": {
                    "FlightType": "OW",
                    "CabinType": "Economy",
                    "RefundableType": "AllFlights",
                    "Currency": "TRY",
                    "DirectFlightsOnly": false,
                    "AvailableFlightsOnly": true,
                    "FareDisplayType": "Lowest"
                  },
                  "AirSearchPaxItems": [
                    {
                      "PaxCode": "ADT",
                      "PaxCount": 1
                    }
                  ],
                  "AirSearchSegments": [
                    {
                      "SequenceNo": 1,
                      "DepartureDay": "2020.01.15",
                      "Origin": {
                        "AirportCode": "IST",
                        "IsCity": false
                      },
                      "Destination": {
                        "AirportCode": "ESB",
                        "IsCity": false
                      }
                    }
                  ]
                }

         * 
         * 
         */

        /// <summary>
        /// "~/Air/Search" endpoint'ine URL yönlendirilir. Metodun içinde MasterPostMethod çağrılır ve wrapper girdisindeki veriler buradan post edilir.
        /// </summary>
        /// <param name="wrapper"></param>
        /// <returns></returns>
        public APIResponse AirSearch(AirSearchWrapper wrapper)
        {
            this.setRequest("/Air/Search");
            return this.MasterPostMethod(wrapper);
        }





        /*       SAMPLE REQUEST BODY (~/Air/Search)
         *     {
                  "SessionHeader": {
                    "SessionId": "cxLuvAhbFdmDXFf47",
                    "SessionToken": "0e7ae860-afe5-41d3-a5cf-3202fab22e73"
                  },
                  "AllocateItems": [
                    {
                      "ProductId": "668d4084-71e6-4819-b989-277e793b2ac7",
                      "MarkupFare": 0
                    }
                  ]
               }
         * 
         */

        /// <summary>
        /// "~/Air/Allocate" endpoint'ine URL yönlendirilir. Metodun içinde MasterPostMethod çağrılır ve wrapper girdisindeki veriler buradan post edilir.
        /// </summary>
        /// <param name="wrapper"></param>
        /// <returns></returns>
        public APIResponse AirAllocate(AirAllocateWrapper wrapper)
        {
            this.setRequest("/Air/Allocate");
            return this.MasterPostMethod(wrapper);
        }







        /*       SAMPLE REQUEST BODY (~/Air/UpdatePassengers)
         *  {
              "SessionHeader": {
	            "SessionId": "cxLuvAhbFdmDXFf47",
                "SessionToken": "0e7ae860-afe5-41d3-a5cf-3202fab22e73"
              },
              "CorporatePin": "",
              "ShoppingCartId": "bcdd3aab-efde-44dd-a50b-83ff4b52774f",
              "Contact": {
                "Name": "Barbaros",
                "LastName": "Kurt",
                "Phone": "+90-5365485786",
                "Email": "barbaros.kurt@arkman.com.tr"
              },
              "Passengers": [
                {
                  "FirstName": "Barbaros",
                  "LastName": "Kurt",
                  "PaxType": "ADT",
                  "Gender": "Male",
                  "BirthDate": "1980-04-29",
                  "Email": "barbaros.kurt@arkman.com.tr",
                  "Phone": "+90-5365485786",
                  "CitizenNo": "50060080200",
                  "PassportNo": "U88485",
                  "Nationality": "Tur",
                  "FrequentFlayerNo": "",
                  "WheelChairService": 0,
                  "PaxReferanceId": "302b8ebf-ea5e-4e2e-9788-d7fa56604534"
                }
              ]
            }
         */

        /// <summary>
        /// "~/Air/UpdatePassengers" endpoint'ine URL yönlendirilir. Metodun içinde MasterPostMethod çağrılır ve wrapper girdisindeki veriler buradan post edilir.
        /// </summary>
        /// <param name="wrapper"></param>
        /// <returns></returns>
        public APIResponse UpdatePassengers(UpdatePassengersWrapper wrapper)
        {
            this.setRequest("/Air/UpdatePassengers");
            return this.MasterPostMethod(wrapper);
        }








        /*       SAMPLE REQUEST BODY (~/Air/UpdatePassengers)
         * {
              "SessionHeader": {
                "SessionId": "cxLuvAhbFdmDXFf47",
                "SessionToken": "0e7ae860-afe5-41d3-a5cf-3202fab22e73"
              },
              "ShoppingCartId": "bcdd3aab-efde-44dd-a50b-83ff4b52774f"
           }
         */

        /// <summary>
        /// "~/Air/MakePrebooking" endpoint'ine URL yönlendirilir. Metodun içinde MasterPostMethod çağrılır ve wrapper girdisindeki veriler buradan post edilir.
        /// </summary>
        /// <param name="wrapper"></param>
        /// <returns></returns>
        public APIResponse MakePrebooking(MakePrebookingWrapper wrapper)
        {
            this.setRequest("/Air/MakePrebooking");
            return this.MasterPostMethod(wrapper);
        }









        /*       SAMPLE REQUEST BODY (~/Air/MakePayment)
         * {
              "SessionHeader": {
                "SessionId": "cxLuvAhbFdmDXFf47",
                "SessionToken": "0e7ae860-afe5-41d3-a5cf-3202fab22e73"
              },
              "ShoppingCartId": "bcdd3aab-efde-44dd-a50b-83ff4b52774f",
              "PaymentType": "CurrentPayment",
              "Amount": 1
	
           }
         */

        /// <summary>
        /// Ödemenin ilk aşamasındaki bilgileri post eder.
        /// "~/MakePayment" endpoint'ine URL yönlendirilir. Metodun içinde MasterPostMethod çağrılır ve wrapper girdisindeki veriler buradan post edilir.
        /// </summary>
        /// <param name="wrapper"></param>
        /// <returns></returns>
        public APIResponse MakePayment(MakePaymentWrapper wrapper)
        {
            this.setRequest("/MakePayment");
            return this.MasterPostMethod(wrapper);
        }








        /*       SAMPLE REQUEST BODY (~/Air/MakePayment) --> END PAYMENT
         * {
              "SessionHeader": {
                "SessionId": "cxLuvAhbFdmDXFf47",
                "SessionToken": "0e7ae860-afe5-41d3-a5cf-3202fab22e73"
              },
              "ShoppingCartId": "bcdd3aab-efde-44dd-a50b-83ff4b52774f",
              "PaymentType": "ThreeDPayment",
              "Amount": 221.98,
              "PayableBank":"Garanti",
              "PaymentForm": {
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
           }
         */

        /// <summary>
        /// Ödemenin son aşamasındaki bilgileri post eder.
        /// "~/MakePayment" endpoint'ine URL yönlendirilir. Metodun içinde MasterPostMethod çağrılır ve wrapper girdisindeki veriler buradan post edilir.
        /// </summary>
        /// <param name="wrapper"></param>
        /// <returns></returns>
        public APIResponse EndPayment(EndPaymentWrapper wrapper)
        {
            this.setRequest("/MakePayment");
            return this.MasterPostMethod(wrapper);
        }







        /*       SAMPLE REQUEST BODY (~/Air/FinalizeShopping)
         * {
              "SessionHeader": {
                "SessionId": "bRmlHEjdpUxHiMd47",
                "SessionToken": "82c9cf43-58d9-40fb-8d3c-f9a75546973f"
              },
              "ShoppingCartId": "09c7367c-4d74-4203-a5f0-10c3da7857f4"
           }
         */

        /// <summary>
        /// "~/Air/FinalizeShopping" endpoint'ine URL yönlendirilir. Metodun içinde MasterPostMethod çağrılır ve wrapper girdisindeki veriler buradan post edilir.
        /// </summary>
        /// <param name="wrapper"></param>
        /// <returns></returns>
        public APIResponse FinalizeShopping(FinalizeShoppingWrapper wrapper)
        {
            this.setRequest("/Air/FinalizeShopping");
            return this.MasterPostMethod(wrapper);
        }






        /*
         * {
              "SessionHeader": {
                "SessionId": "bRmlHEjdpUxHiMd47",
                "SessionToken": "82c9cf43-58d9-40fb-8d3c-f9a75546973f"
              },
              "ShoppingCartId": "09c7367c-4d74-4203-a5f0-10c3da7857f4",
              "BillingInformation": {
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
           }
         */

        /// <summary>
        /// "~/Billing/Submit" endpoint'ine URL yönlendirilir. Metodun içinde MasterPostMethod çağrılır ve wrapper girdisindeki veriler buradan post edilir.
        /// </summary>
        /// <param name="wrapper"></param>
        /// <returns></returns>
        public APIResponse BillingSubmit(BillingSubmitWrapper wrapper)
        {
            this.setRequest("/Billing/Submit");
            return this.MasterPostMethod(wrapper);
        }








        /*
         * {
              "SessionHeader": {
                "SessionId": "bRmlHEjdpUxHiMd47",
                "SessionToken": "82c9cf43-58d9-40fb-8d3c-f9a75546973f"
              },
              "ShoppingCartId": "09c7367c-4d74-4203-a5f0-10c3da7857f4"
           }
         */

        /// <summary>
        /// "~/GetShoppingCart" endpoint'ine URL yönlendirilir. Metodun içinde MasterPostMethod çağrılır ve wrapper girdisindeki veriler buradan post edilir.
        /// </summary>
        /// <param name="wrapper"></param>
        /// <returns></returns>
        public APIResponse GetShoppingCart(GetShoppingCartWrapper wrapper)
        {
            this.setRequest("/GetShoppingCart");
            return this.MasterPostMethod(wrapper);
        }
    }
}