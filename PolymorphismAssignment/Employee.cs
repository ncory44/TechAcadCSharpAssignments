using System;

public class Employee : Person, IQuittable
{
    public int Id { get; set; }
    public override void SayName()
    {
        Console.WriteLine($"Name: {firstName} {lastName}");
    }

    //implementing the quit method
    public void Quit()
    {
        Console.WriteLine($"{firstName} {lastName} has quit the job.");
    }
}