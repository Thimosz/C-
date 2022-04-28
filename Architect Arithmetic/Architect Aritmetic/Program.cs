using System;

namespace ArchitectArithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
            double totalArea = Rectangle(1500, 2500) + Triangle(750, 500) + 0.5 * Circle(375);
            double totalCosts = Math.Round(totalArea * 180, 2);
            Console.WriteLine($"The total costs for the flooring materials is {totalCosts} Mexican pesos.");
        }

        static double Rectangle(double length, double width)
        {
            double rectArea = length * width;
            return rectArea;
        }

        static double Circle(double radius)
        {
            double circArea = Math.PI * Math.Pow(radius, 2);
            return circArea;
        }
        static double Triangle(double bottom, double heigth)
        {
            double triangleArea = 0.5 * bottom * heigth;
            return triangleArea;
        }
    }
}
