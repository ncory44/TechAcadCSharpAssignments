using System;

class Program
{
    static void Main(string[] args)
    {
        //employee with string type
        Employee<string> employeeStrings = new Employee<string>
        {
            firstName = "Guy",
            lastName = "Fieri",
            things = new List<string> { "Spatula", "Hair Gel", "Fire Shirt" }
        };

        //employee with int type
        Employee<int> employeeInts = new Employee<int>
        {
            firstName = "Gordon",
            lastName = "Ramsay",
            things = new List<int> { 1, 2, 3 }
        };

        //print string things
        Console.WriteLine(employeeStrings.firstName + "'s things: ");
        foreach (string thing in employeeStrings.things)
        {
            Console.WriteLine("- " + thing);
        }

        //print int things
        Console.WriteLine(employeeInts.firstName + "'s things: ");
        foreach (int thing in employeeInts.things)
        {
            Console.WriteLine("- " + thing);
        }
    }
}