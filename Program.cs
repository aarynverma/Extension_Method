using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToCheckCurrency
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value");
            string input = Console.ReadLine();
            string Currency = new string(input);
            Currency.ToCurrency();
            Console.WriteLine(Currency);
             
        }
    }
}
