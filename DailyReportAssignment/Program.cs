using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report");
        Console.WriteLine();

        Console.WriteLine("What is your name?");
        string studentName = Console.ReadLine();

        Console.WriteLine("What course are you on?");
        string courseName = Console.ReadLine();

        Console.WriteLine("What page number?");
        int pageNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
        bool needHelp = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
        string positiveExperiences = Console.ReadLine();

        Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
        string feedback = Console.ReadLine();

        Console.WriteLine("How many hours did you study today?");
        double hoursStudied = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
    }
}  