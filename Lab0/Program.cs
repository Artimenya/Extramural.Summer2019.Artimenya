using System;

namespace Lab0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the First Number: ");
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Second Number: ");
            int val2 = Convert.ToInt32(Console.ReadLine());
            int tmp = val1;
            val1 = val2;
            val2 = tmp;

            Console.Write("After Swapping: \n");
            Console.Write("First Number: " + val1 + "\n");
            Console.Write("Second Number: " + val2 + "\n");
        }
    }
}
