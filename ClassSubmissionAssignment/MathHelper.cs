using System;

public class MathHelper
{
    //takes an int, divides it by 2, and returns the result
    public void DivideByTwo(int number)
    {
        int result = number / 2;
        Console.WriteLine($"Half of {number} is: {result}");
    }

    //output parameters
    public void GetHalves(int number, out int half, out int remainder)
    {
        half = number / 2;
        remainder = number % 2;
    }

    //overloading
    public void DivideByTwo(decimal number)
    {
        decimal result = number / 2;
        Console.WriteLine($"Half of {number} is: {result}");
    }
}