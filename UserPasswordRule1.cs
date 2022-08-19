﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserPassword
{
    public class UserPasswordRule1
    {
        public static string REGEX_PASSWORD = "^[A-Z a-z]{8}$";
        public bool ValidatePassword(string Password)
        {
            return Regex.IsMatch(Password, REGEX_PASSWORD);

        }
    }
}
