using System;

public class Person
{
    public string firstName { get; set; }
    public string lastName { get; set; }

    public void sayName()
    {
        Console.WriteLine("Name: " + firstName + " " + lastName);
    }
}