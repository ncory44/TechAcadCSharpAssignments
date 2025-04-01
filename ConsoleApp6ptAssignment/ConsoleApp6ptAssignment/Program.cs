using System;

class Program
{
    static void Main(string[] args)
    {
        //PART ONE
        //one dimmensional array of strings in the form of shakespeare quotes
        string[] phrases = { "Tomorrow, and tomorrow, and tomorrow", "Creeps in this pretty pace from day to day", "To the last syllable of recorded time", "And all our yesterdays have lighted fools", "The way to dusty death. Out, out, brief candle!", "Life's but a walking shadow, a poor player", "That struts and frets his hour upon the stage", "And then is heard no more. It is a tale", "Told by an idiot, full of sound and fury", "Signifying nothing." };

        //ask the user for input
        Console.WriteLine("Please enter text to add to each phrase: ");
        string userText = Console.ReadLine();

        //loop to append user input to each string inside the array
        for (int i = 0; i < phrases.Length; i++)
        {
            phrases[i] = phrases[i] + " " + userText;
        }

        //loop to print out the new phrases
        Console.WriteLine("\nUpdated Phrases: ");
        foreach (string phrase in phrases)
        {
            Console.WriteLine(phrase);
        }

        Console.WriteLine("\nRunning a loop");

        //PART TWO
        //originally said "while (true)" which would run forever, now fixed to run 5 times
        int counter = 0;
        while (counter < 5)
        {
            Console.WriteLine("Fixed loop counter " + counter);
            counter++;
        }

        //PART THREE
        //loop using the "<" operator
        Console.WriteLine("\nLoop using the '<' operator:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("i is " + i);
        }

        //loop using the "<=" operator
        Console.WriteLine("\nLoop using the '<=' operator:");
        for (int i = 0; i <= 3; i++)
        {
            Console.WriteLine("i is " + i);
        }

        //PART FOUR
        //unique list of strings, asks the user to enter vacation destination to search for
        List<string> vacationSpots = new List<string> { "New Zealand", "Costa Rica", "Japan", "Hawaii", "Yosemite" };

        Console.WriteLine("\nHere is a list of vacation destinations: New Zealand, Costa Rica, Japan, Hawaii, Yosemite");
        Console.WriteLine("Please enter a vaction destination to search for in the list: ");

        string searchInput = Console.ReadLine();
        bool matchFound = false;

        for (int i = 0; i < vacationSpots.Count; i++)
        {
            if (vacationSpots[i].Equals(searchInput, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Match found at index " + i);
                matchFound = true;
                break; //stops the loop when a match is found
            }
        }

        if (!matchFound)
        {
            Console.WriteLine("No match found");
        }

        //PART FIVE
        //list with duplicate strings
        List<string> orderedDesserts = new List<string> { "bread pudding", "berry pie", "coconut ice cream", "bread pudding", "berry pie", "coconut ice cream", "coconut ice cream" };

        Console.WriteLine("\nHere is a list of desserts ordered by customers: bread pudding, berry pie, coconut ice cream, bread pudding, berry pie, coconut ice cream, coconut ice cream");

        Console.WriteLine("Please enter a food to search for in the list: ");
        string searchFood = Console.ReadLine();
        bool foundMatch = false;

        //searches the list for any matching strings
        for (int i = 0; i < orderedDesserts.Count; i++)
        {
            if (orderedDesserts[i].Equals(searchFood, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Match found at index " + i);
                foundMatch = true;
            }
        }

        if (!foundMatch)
        {
            Console.WriteLine("No match found");
        }

        //PART SIX
        //creating a foreach loop that evaluates dublicate items in a list and displays a message showing the string and whther or not it has already appeared in the list
        List<string> motorcycleList = new List<string> { "Harley Davidson", "Honda", "Yamaha", "Suzuki", "Kawasaki", "Ducati", "Harley Davidson", "Honda", "Yamaha", "Suzuki", "Kawasaki", "Ducati" };

        List<string> seenMotorcycles = new List<string>();

        Console.WriteLine("\nChecking each motorcycle to see if it's already appeared:\n");

        foreach (string motorcycle in motorcycleList)
        {
            if (seenMotorcycles.Contains(motorcycle))
            {
                Console.WriteLine(motorcycle + " has already appeared in the list.");
            }
            else
            {
                Console.WriteLine(motorcycle + " is a new entry.");
                seenMotorcycles.Add(motorcycle);
            }
        }

    }
}