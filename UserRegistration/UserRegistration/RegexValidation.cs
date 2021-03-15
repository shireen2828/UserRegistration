using System;
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
        public static string Regex_MobileNumber = "^[1-9]{0,2}\\s[1-9]{1}[0-9]{9}$";
        public static string Regex_Password = "^[A-Za-z]{8,}$";

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
        public bool ValidateMobileNumber(string MobileNumber)
        {
            return Regex.IsMatch(MobileNumber, Regex_MobileNumber);
        }
        public bool ValidatePassword(string Password)
        {
            return Regex.IsMatch(Password, Regex_Password);
        }
    }
}

