using System;

class Program
{
    static void Main(string[] args)
    {
        //instantiates the class
        OptionalMath math = new OptionalMath();

        Console.WriteLine("Welcome to the math program, with the best kind of math: optional. The number we'll be working with today is: 7. \nYou will be presented with options to add numbers to this intiger.");

        //asks the user for the first number
        Console.WriteLine("Enter the first number:");
        string input1 = Console.ReadLine();
        int a = Convert.ToInt32(input1);

        //asks the user for the second number
        Console.WriteLine("Enter the second number (or press Enter to skip):");
        string input2 = Console.ReadLine();

        int result;

        if (string.IsNullOrWhiteSpace(input2))
        {
            //first number entered
            result = math.AddNumbers(a);
        }
        else
        {
            //both numbers entered
            int b = Convert.ToInt32(input2);
            result = math.AddNumbers(a, b);
        }

        Console.WriteLine($"The result is: {result}");
    }
}