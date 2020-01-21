using System;

namespace Lab4
{
    //Write a C# program to compute the distance between two points on the surface of earth.
    //d = radius * arccos(sin(x1) * sin(x2) + cos(x1) * cos(x2) * cos(y1 - y2))
    //Distance between the two points [ (x1,y1) & (x2,y2)]
    //Radius of the earth r = 6371.01 Kilometers
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the latitude of coordinate 1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the longitude of coordinate 1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the latitude of coordinate 2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the longitude of coordinate 2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double radius = 6371.01;
            double distance = radius * Math.Acos(Math.Sin(x1) * Math.Sin(x2) + Math.Cos(x1) * Math.Cos(x2) * Math.Cos(y1 - y2));

            Console.WriteLine("The distance between those points is:: " + distance);
        }
    }
}
