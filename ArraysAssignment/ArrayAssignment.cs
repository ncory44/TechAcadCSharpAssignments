using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //string array
        string[] dogBreeds = { "Shiba-Inu", "German Shepard", "Lab", "Blue Heeler", "Poodle" };
        Console.WriteLine("Select an index (0-4) to view a dog breed: ");

        int index1 = Convert.ToInt32(Console.ReadLine());

        if (index1 >= 0 && index1 < dogBreeds.Length)
        {
            Console.WriteLine("The breed you selected is: " + dogBreeds[index1]);
        }
        else
        {
            Console.WriteLine("That index doesn't exist in the dog breed array");
        }

        Console.WriteLine();

        //integer array
        int[] numbers = { 7, 14, 21, 28, 35};
        Console.WriteLine("Select an index (0-4) to view a number: ");

        int index2 = Convert.ToInt32(Console.ReadLine());

        if (index2 >= 0 && index2 < numbers.Length)
        {
            Console.WriteLine("You selected: " + numbers[index2]);
        }
        else
        {
            Console.WriteLine("That index doesn't exist in the numbers array");
        }

        Console.WriteLine();

        //string list
        List<string> instruments = new List<string> { "Cello", "Guitar", "Basoon", "Bass Clarinet", "Viola"};
        Console.WriteLine("Select an index (0-4) to view an instrument: ");

        int index3 = Convert.ToInt32(Console.ReadLine());

        if (index3 >= 0 && index3 < instruments.Count)
        {
            Console.WriteLine("You selected: " + instruments[index3]);
        }
        else
        {
            Console.WriteLine("That index doesn't exist in the instrument list!");
        }

        Console.WriteLine("\nThanks for using the viewer app :)");
    }
}