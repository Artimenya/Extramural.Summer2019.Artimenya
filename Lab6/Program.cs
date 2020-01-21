using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = DateTime.Now;
            String wday = time.DayOfWeek.ToString();
            String month = time.ToString("MMMM");
            String date = time.Day.ToString();
            String year = time.Year.ToString();
            Console.WriteLine("Current Date time: " + wday + ", " + month + " " + date + ", " + year);
        }
    }
}
