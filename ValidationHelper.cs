using System;
using System.Text.RegularExpressions;


namespace AddressBook
{
    public class ValidationHelper
    {
        public static bool IsValid(string fullname, string email, string phoneNumber)
        {
            if (IsValidName(fullname) && IsValidEmail(email) && IsValidPhone(phoneNumber))
                return true;

            return false;
        }

        public static bool IsValidName(string fullname)
        {
            if (fullname.Length == 0 || !Regex.IsMatch(fullname, "^[a-zA-z]+ [a-zA-z]+$"))
            {
                Console.WriteLine("Full Name is not valid");
                return false;
            }
            return true;
        }

        public static bool IsValidPhone(string phone)
        {
            if (phone.Length == 0 || !Regex.IsMatch(phone, "[0-9]+$"))
            {
                Console.WriteLine("Phone number is not valid");
                return false;
            }
            return true;
        }

        public static bool IsValidEmail(string email)
        {
            if (email.Length == 0 || !Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                Console.WriteLine("Email address is not valid");
                return false;
            }
            return true;
        }
    }
}