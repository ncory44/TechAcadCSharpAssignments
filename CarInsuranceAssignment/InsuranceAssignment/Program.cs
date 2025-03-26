using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Car Insurance Approval Program");
        Console.WriteLine();

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Have you ever had a DUI? (true/false): ");
        bool hasDUI = Convert.ToBoolean(Console.ReadLine());

        Console.Write("How many speeding tickets do you have? ");
        int speedingTickets = Convert.ToInt32(Console.ReadLine());

        bool isQualified = (age > 15) && (hasDUI == false) && (speedingTickets <= 3);

        Console.WriteLine("Qualified?");
        Console.WriteLine(isQualified);
    }
}