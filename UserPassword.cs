using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserPasswordRule2
{
    public class UserPassword
    {
        public static string REGEX_PASSWORD = "^[A-Z]{1}[A-Z a-z]{7}$";
        public bool ValidatePasswordTwo(string Password)
        {
            return Regex.IsMatch(Password, REGEX_PASSWORD);
        }
    }
}
