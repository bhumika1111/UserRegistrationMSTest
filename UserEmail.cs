﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace UserValidEmail
{
    public class UserEmail
    {

        public static string REGEX_EMAIL = "^[a-z]{3,7}[0-9]{3}['@'][a-z]{5}['.'][a-z]{3}$";
        public bool ValidateEmail(string Email)
        {
            return Regex.IsMatch(Email, REGEX_EMAIL);
        }
    }
}
