using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer
{
    /*
     *    "AvailableBanks": [
            {
              "Name": "TurkiyeFinans",
              "IsDefault": true
            },
            {
              "Name": "Halkbank",
              "IsDefault": false
            },
            {
              "Name": "Akbank",
              "IsDefault": false
            },
            {
              "Name": "Isbank",
              "IsDefault": false
            },
            {
              "Name": "YapiKredi",
              "IsDefault": false
            },
            {
              "Name": "Garanti",
              "IsDefault": false
            },
            {
              "Name": "Vakifbank",
              "IsDefault": false
            },
            {
              "Name": "KuveytTurk",
              "IsDefault": false
            },
            {
              "Name": "Capital",
              "IsDefault": false
            },
            {
              "Name": "Ziraat",
              "IsDefault": false
            }
          ]
    
     */

    public class AvailableBank
    {
        public String Name;
        public Boolean IsDefault;

        public AvailableBank(string name, bool ısDefault)
        {
            Name = name;
            IsDefault = ısDefault;
        }
    }
}
