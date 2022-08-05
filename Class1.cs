using System;
using System.Text.RegularExpressions;

namespace ToCheckCurrency
{

    public static class ToCheckCurrency
    {

        public static string ToCurrency(this string str)
        {
            var isNumber = Regex.IsMatch(str, @"^\d+$");

            if (!isNumber)
                return str;

            else
                throw new Exception("Invalid Value!");

        }

    }
}