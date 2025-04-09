using System;

public class Employee : Person
{
    public override void SayName()
    {
        Console.WriteLine($"Name: {firstName} {LastName}");
    }
}