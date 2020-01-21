using System;

namespace Laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i;
            int[] array = new int[20];
            Console.Write("Enter  decimal number: ");
            num = int.Parse(Console.ReadLine());
            for (i = 0; num > 0; i++)
            {
                array[i] = num % 2;
                num = num / 2;
            }
            Console.Write("Binary number: ");

            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(array[i]);
            }
        }
    }
}
