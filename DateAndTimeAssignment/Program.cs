using System;

class Program
{
    static void Main(string[] args)
    {
        //prints current date and time
        DateTime now = DateTime.Now;
        Console.WriteLine("Current Date and Time: " + now);

        //asks the user for number of hours
        Console.Write("Enter the number of hours to add: ");
        string input = Console.ReadLine();

        //parses the input to an integer
        if (int.TryParse(input, out int hoursToAdd))
        {
            //adds the hours to the current date and time
            DateTime futureTime = now.AddHours(hoursToAdd);
            Console.WriteLine("In {0} hour(s), the time will be {1}", hoursToAdd, futureTime );
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }

        Console.ReadLine();
    }
}