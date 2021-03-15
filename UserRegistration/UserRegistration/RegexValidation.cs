﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Validators
    {
        public static string Regex_FirstName = "^[A-Z]{1}[a-zA-Z]{2,}";
        public static string Regex_LastName = "^[A-Z]{1}[A-Za-z]{2,}";
        public static string Regex_EmailId = "^[A-Za-z0-9]+([.#_+-][0-9A-Za-z]+)*([@][A-Za-z0-9]+[.][A-Za-z]{2,3})([.][A-Za-z]{2})$";
        public bool ValidateFirstName(string FirstName)
        {
            return Regex.IsMatch(FirstName, Regex_FirstName);
        }
        public bool ValidateLastName(string LastName)
        {
            return Regex.IsMatch(LastName, Regex_LastName);
        }
        public bool ValidateEmailId(string EmailId)
        {
            return Regex.IsMatch(EmailId, Regex_EmailId);
        }
    }
}

