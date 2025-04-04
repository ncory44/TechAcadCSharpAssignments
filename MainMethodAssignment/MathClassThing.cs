using System;

public class MathClassThing
{
    //method that takes an integer and adds 10
    public int DoMath(int number)
    {
        return number + 10;
    }

    //method that takes a decimal and multiplies it by 2
    public int DoMath(decimal number)
    {
        return (int)(number * 2);
    }

    //method that tries to convert a string to int if possible and subtract 5
    public int Domath(string numberStr)
    {
        int parsedNumber = Convert.ToInt32(numberStr);
        return parsedNumber - 5;
    }
}