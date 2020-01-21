using System;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C# program to capitalize the first letter of each word in a sentence.
            //the quick brown fox jumps over the lazy dog.
            Console.WriteLine("Test Data:");
            String val = Console.ReadLine();

            val = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(val);
            Console.WriteLine("Result string: " + val);
        }
    }
}
