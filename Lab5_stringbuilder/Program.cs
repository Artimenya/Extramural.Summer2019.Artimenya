using System;
using System.Text;
namespace Lab5_stringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C# program to reverse a string (use class String, use ckass StringBuilder).
            Console.WriteLine("Input a string: ");
            string val = Console.ReadLine();

            StringBuilder builder = new StringBuilder();
            for (int i = val.Length - 1; i >= 0; i--)
            {
                builder.Append(val[i]);
            }
            string output = builder.ToString();

            Console.WriteLine("Reverse string: " + output);
        }
    }
}
