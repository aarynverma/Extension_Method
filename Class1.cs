using System;
using System.Text.RegularExpressions;

namespace ToCheckCurrency
{
    public class InvalidInputException : Exception
    {
        public InvalidInputException(String Message)
            : base(Message) { }
    }
    public static class ToCheckCurrency
    {


        public static string ToCurrency(this string str)
        {
            var isNumber = Regex.IsMatch(str, @"^\d+$");

            if (!isNumber)
                return str;
             
            else
                throw new InvalidInputException("Invalid Input!");

        }

    }
}