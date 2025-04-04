using System;

class Program
{
    static void Main(string[] args)
    {
        //instantiate overloadmath class
        MathClassThing math = new MathClassThing();

        //call method with integer
        int result1 = math.DoMath(10);
        Console.WriteLine("Integer input (10) + 10 = " + result1);

        //calls method with decimal
        int result2 = math.DoMath(13.5m);
        Console.WriteLine("Decimal input (13.5) * 2 = " + result2);

        //calls method with string and convert it to int
        int result3 = math.DoMath("20");
        Console.WriteLine("String input (20) - 5 = " + result3);
    }
}