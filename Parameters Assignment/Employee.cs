using System;

public class Employee<T> : Person, IQuittable
{
    public int Id { get; set; }

    //generic list
    public List<T> things { get; set; }

    public override void SayName()
    {
        Console.WriteLine("Name: " + firstName + " " + lastName);
    }

    public void Quit()
    {
        Console.WriteLine("Employee has quit.");
    }
}