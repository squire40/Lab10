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
                        input = Console.ReadLine();

                        if (!Validator.IsValidDouble(input))
                        {
                            throw new FormatException("Invalid value, please re-enter");
                        }

                        radius = double.Parse(input);
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);

                        isValid = false;
                    }
                } while (!isValid);

                c = new Circle(radius);

                circles.Add(c);

                Console.WriteLine($"Circumference: {c.CalculateFormattedCircumference()}");

                Console.WriteLine($"Area: {c.CalculateFormattedArea()}");

                do
                {
                    isValid = true;

                    Console.WriteLine("Continue? y/n");

                    input = Console.ReadLine();

                    if (!Validator.IsYesOrNo(input))
                    {
                        Console.WriteLine("Invalid response.  Enter y or n");
                        isValid = false;
                    }

                    shouldContinue = input.Equals("y", StringComparison.InvariantCultureIgnoreCase);
                } while (!isValid);

            } while (shouldContinue);

            Console.WriteLine($"Goodbye.  You created {circles.Count} circles");
            Console.ReadKey();
        }
    }
}
