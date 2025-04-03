using System;

class Program
{
    static void Main(string[] args)
    {
        //ask the user for a number
        Console.WriteLine("Please enter a number:");
        string input = Console.ReadLine();
        int usersNumber = Convert.ToInt32(input);

        //creates an instance of the MathOperations class
        MathOperations math = new MathOperations();

        //calls the AddTen method and stores the result
        int added = math.AddTen(usersNumber);
        Console.WriteLine("Your number plus 10 is: " + added);

        //calls the MultiplyByFive method and stores the result
        int multiplied = math.MultiplyByFive(usersNumber);
        Console.WriteLine("Your number multiplied by 5 is: " + multiplied);

        //calls the SubtractThree method and stores the result
        int subtracted = math.SubtractThree(usersNumber);
        Console.WriteLine("Your number minus 3 is: " + subtracted);
    }
}