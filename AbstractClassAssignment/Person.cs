using System;

public abstract class Person
{
    public string firstName { get; set; }
    public string LastName { get; set; }

    public abstract void SayName();
}