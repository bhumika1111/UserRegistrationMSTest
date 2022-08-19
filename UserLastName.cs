using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationMSTest
{
    public class UserLastName
    {
        public static string REGEX_LASTNAME = "^[A-Z]{1}[a-z]{2,7}$";
        public bool ValidateLastName(string LastName)
        {
            return Regex.IsMatch(LastName, REGEX_LASTNAME);

        }
    }
}
