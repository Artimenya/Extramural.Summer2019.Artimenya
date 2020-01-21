using System;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = DateTime.Now;
            String date = time.ToString(DateTime.Now.ToString("MM/dd/yyyy"));

            Console.WriteLine("Current Date time: " + date);
        }
    }
}
