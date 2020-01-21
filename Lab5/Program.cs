using System;
using System.Text;
namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C# program to reverse a string (use class String, use ckass StringBuilder).
            Console.WriteLine("Input a string: ");
            string val = Console.ReadLine();
            int l = val.Length - 1;
            string newstring = "";
            while (l >= 0)
            {
                newstring = newstring + val[l];
                l--;
            }

            Console.WriteLine("Reverse string: " + newstring);
        }
    }
}
