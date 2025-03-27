﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        //pkg weight
        Console.WriteLine("Please enter the package weight: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        if (weight > 50)
        {
            Console.WriteLine("Your package is too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        //dimensions
        Console.WriteLine("Please enter the package width: ");
        double width = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Please enter the package height: ");
        double height = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Please enter the package length: ");
        double length = Convert.ToDouble(Console.ReadLine());

        double dimensionTotal = width + height + length;

        if (dimensionTotal > 50)
        {
            Console.WriteLine("Your package is too big to be shipped via Package Express.");
            return;
        }

        //quote
        double quote = (dimensionTotal * weight) / 100;

        //output
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));
        Console.WriteLine("Thank you!");
    }
}