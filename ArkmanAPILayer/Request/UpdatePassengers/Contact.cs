using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer
{

    /*
     *"Contact": {
        "Name": "Barbaros",
        "LastName": "Kurt",
        "Phone": "+90-5365485786",
        "Email": "barbaros.kurt@arkman.com.tr"
       } 
     */

    public class Contact
    {
        public String Name;
        public String LastName;
        public String Phone;
        public String Email;

        public Contact(string name, string lastName, string phone, string email)
        {
            Name = name;
            LastName = lastName;
            Phone = phone;
            Email = email;
        }
    }
}
