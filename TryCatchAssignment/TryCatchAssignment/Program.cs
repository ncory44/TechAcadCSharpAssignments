class Program
{
    static void Main(string[] args)
    {
        //list of integers
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50, 60, 70, 80, 90 };

        Console.WriteLine("Enter a number to divide each number in the list by: ");

        //try/catch handling exceptions
        try
        {
            string userInput = Console.ReadLine();
            int divisor = Convert.ToInt32(userInput);

            foreach (int number in numbers)
            {
                int result = number / divisor;
                Console.WriteLine(number + " divided by " + divisor + " equals " + result);
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: Please type a whole number.");
            Console.WriteLine("Details: " + ex.Message);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
            Console.WriteLine("Details: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred.");
            Console.WriteLine("Details: " + ex.Message);
        }

        Console.WriteLine("\nProgram has emerged from the try/catch block and continued on with the program.");
    }
}