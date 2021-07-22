using System;

namespace Studio_Area_of_Circle
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;
            double radius;
            //double area;
            //double circumference;
            //double diameter;
            double mpg;
            double amtOfGas;

            Console.WriteLine("Please enter a radius: ");
            input = Console.ReadLine();
            radius = double.Parse(input);

            Console.WriteLine("Enter mpg of your car: ");
            input = Console.ReadLine();
            mpg = double.Parse(input);

            //area = Math.Round(Math.PI * Math.Pow(radius, 2.0), 2);
            //circumference = Math.Round((2 * Math.PI * radius), 2);
            //diameter = Math.Round((2 * radius), 2);
            amtOfGas = Math.Round((Circle.GetCircumference(radius) / mpg), 2);

            Console.WriteLine("The area of a circle with a radius of " + radius + " is: " + Circle.GetArea(radius));
            Console.WriteLine("The circumference of a circle with radius of " + radius + " is: " + Circle.GetCircumference(radius));
            Console.WriteLine("The diameter of a circle with radius of " + radius + " is: " + Circle.GetDiameter(radius));
            Console.WriteLine("The amout of gas used to drive " + Circle.GetCircumference(radius) + " is: " + amtOfGas);

            Console.WriteLine("Hello!");

        }
    }
}
