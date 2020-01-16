using System;
using System.Collections.Generic;
using System.Text;

namespace ArkmanAPILayer.Wrappers
{
    public class LoginWrapper : Wrapper
    {
        public String Username;
        public String Password;
        public Boolean IsTest;

        public LoginWrapper(string username, string password, bool ısTest)
        {
            Username = username;
            Password = password;
            IsTest = ısTest;
        }
    }
}
