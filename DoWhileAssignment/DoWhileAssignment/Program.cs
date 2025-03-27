using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Boolean comparison with a While Loop");

        int count = 0;

        while (count < 10)
        {
            Console.WriteLine("Count is "+ count);
            count++;
        }

        Console.WriteLine("\nBoolean comparison with a Do While Loop");

        int number;
        do
        {
            Console.Write("Enter a number greater than 10: ");
            number = Convert.ToInt32(Console.ReadLine());
        }
        while (number <= 10);

        Console.WriteLine("You entered: " + number);
    }
}