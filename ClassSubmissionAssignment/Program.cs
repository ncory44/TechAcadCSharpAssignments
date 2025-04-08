using System;

class Program
{ 
    static void Main(string[] args)
    {
        //call static method
        StaticUtilities.SayHello();

        //asks user for input
        Console.WriteLine("Please enter a number:");
        string input = Console.ReadLine();
        int userNumber = Convert.ToInt32(input);

        //create an instance of MathHelper
        MathHelper math = new MathHelper();

        //divides by 2 and displays result
        math.DivideByTwo(userNumber);

        //output parameters
        math.GetHalves(userNumber, out int half, out int remainder);
        Console.WriteLine($"Using out parameters: Half = {half}, Remainder = {remainder}");

        //overloading
        decimal decimalNumber = 10.5m;
        math.DivideByTwo(decimalNumber);
    }
}