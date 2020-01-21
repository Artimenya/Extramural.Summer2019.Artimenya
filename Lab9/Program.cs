using System;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C# program to find the first N prime numbers.
            Console.WriteLine("Input a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int c, i = 0, count;
            int[] array = new int[100];

            for (count = 0; count < num; i++)
            {
                // iteration to check c is prime or not
                for (c = 2; c < i; c++)
                {
                    if (i % c == 0)
                        break;
                }

                if (c == i)  // c is prime
                {
                    array[count] = i;
                    count++;    // increment the count of prime numbers
                }

            }
            Console.WriteLine("First " + num + " prime numbers: ");
            for (i = 0; i < count; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
