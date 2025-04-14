using System;

class Program
{
    //defines enum
    public enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the current day of the week:");

        try
        {
            string userInput = Console.ReadLine();

            //parsing enum
            DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput, ignoreCase: true);

            Console.WriteLine($"You selected: {currentDay}");
        }
        catch
        {
            Console.WriteLine("Please enter an actual day of the week.");
        }
    }
}
