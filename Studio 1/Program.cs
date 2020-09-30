using System;
using System.Net.Mime;

namespace Studio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double area;
            string inputRadius;
            double radius = 0;
            double circumference;
            double diameter;
            string inputMiles;
            double miles;
            double distance;
            double number;

            while (radius <= 0) {
                Console.WriteLine("Enter a radius: ");
                inputRadius = Console.ReadLine();
                if (inputRadius == "" || !Double.TryParse(inputRadius, out number))
                {
                    Console.WriteLine("String can not be empty or a letter");
                    radius = 0;
                }
                else
                {
                    radius = double.Parse(inputRadius);
                }
            }

            Console.WriteLine("Enter a miles per gallon: ");
            inputMiles = Console.ReadLine();
            miles = double.Parse(inputMiles);

            area = Math.Pow(radius, 2.0) * Math.PI;
            Console.WriteLine("The area of a circle of radius " + radius + " is: " + area);

            diameter = 2 * radius;
            Console.WriteLine("The dimeter of a circle of radius " + radius + " is: " + diameter);
            circumference = diameter * Math.PI;
            Console.WriteLine("The circumference of a circle of radius " + radius + " is: " + circumference);

            distance = circumference / miles;
            Console.WriteLine("The amount of gallons needed to drive around a circle " + circumference + " long is: " + distance);
           
        }
    }
}
