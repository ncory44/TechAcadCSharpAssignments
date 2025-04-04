using System;

class Program
{
    static void Main(string[] args)
    {
        //instantiate the MathAction class
        MathAction mathAction = new MathAction();

        //call the DoSomething method
        Console.WriteLine("Calling method passing in two numbers:");
        mathAction.DoSomething(5, 10);

        //call the doSomething method with specified parameters
        Console.WriteLine("\nCalling method passing in two numbers with specified parameters:");
        mathAction.DoSomething(x: 7, y: 14);
    }
}