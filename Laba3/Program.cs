using System;

namespace Laba3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C# program to convert a hexadecimal to a decimal number.
            Console.WriteLine("Enter a hexadecimal number: ");
            string hnumber = Console.ReadLine();
            int decnumber = int.Parse(hnumber, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine("Decimal number: " + decnumber);
        }
    }
}
