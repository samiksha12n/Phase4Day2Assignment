using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitSignInLib
{
    public class SignIn
    {
        public string Authenticate(string username, string password)
        {
            string result = "";
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                result = "Please provide username and password";
            }
            else
            {
                if (username == "sam" && password == "sam@1256")
                {
                    result = "Authentication Pass";
                }
                else
                {
                    result = "Authentication Fail";
                }
            }
            return result;
        }
    }
}
