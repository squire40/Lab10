using System;
using System.Collections.Generic;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = null;
            var isValid = false;
            var shouldContinue = false;
            double radius = 0;
            Circle c = null;
            List<Circle> circles = new List<Circle>();

            Console.WriteLine("Welcome to the Circle Tester");

            do
            {
                shouldContinue = true;

                do
                {
                    try
                    {
                        isValid = true;
                        Console.WriteLine("Enter radius:");
                        radius = double.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Enter a valid value.");
                        isValid = false;
                    }
                } while (!isValid);

                c = new Circle(radius);

                circles.Add(c);

                Console.WriteLine($"Circumference: {c.CalculateFormattedCircumference()}");

                Console.WriteLine($"Area: {c.CalculateFormattedArea()}");

                Console.WriteLine("Continue? y/n");

                shouldContinue = Console.ReadLine().Equals("y", StringComparison.InvariantCultureIgnoreCase);

            } while (shouldContinue);

            Console.WriteLine($"Goodbye.  You created {circles.Count} circles");
            Console.ReadKey();
        }
    }
}
