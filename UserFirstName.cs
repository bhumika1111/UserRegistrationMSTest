using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UserFirstName
    {
        public static string REGEX_FIRSTNAME = "^[A-Z]{1}[a-z]{2,7}$";
        public bool ValidateFirstName(string FirstName)
        {
            return Regex.IsMatch(FirstName, REGEX_FIRSTNAME);

        }
    }
}
