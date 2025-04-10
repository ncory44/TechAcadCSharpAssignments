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

    //overloading the == operator
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        return emp1.Id == emp2.Id;
    }

    //overloading the != operator
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return emp1.Id != emp2.Id;
    }

    //overriding the equals method
    public override bool Equals(object obj)
    {
        if (obj is Employee emp)
        {
            return this.Id == emp.Id;
        }
        return false;
    }
}