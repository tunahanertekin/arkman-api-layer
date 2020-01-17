using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer
{
    /*
     *{
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
     */

    public class Passenger
    {
        public String FirstName;
        public String LastName;
        public String PaxType;
        public String Gender;
        public String BirthDate;
        public String Email;
        public String Phone;
        public String CitizenNo;
        public String PassportNo;
        public String Nationality;
        public String FrequentFlayerNo;
        public int WheelChairService;
        public String PaxReferanceId;

        public Passenger(string firstName, string lastName, string paxType, string gender, string birthDate, string email, string phone, string citizenNo, string passportNo, string nationality, string frequentFlayerNo, int wheelChairService, string paxReferenceId)
        {
            FirstName = firstName;
            LastName = lastName;
            PaxType = paxType;
            Gender = gender;
            BirthDate = birthDate;
            Email = email;
            Phone = phone;
            CitizenNo = citizenNo;
            PassportNo = passportNo;
            Nationality = nationality;
            FrequentFlayerNo = frequentFlayerNo;
            WheelChairService = wheelChairService;
            PaxReferanceId = paxReferenceId;
        }
    }
}
