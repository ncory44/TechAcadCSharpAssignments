using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //list of 10 employees
        List<Employee> employees = new List<Employee>
        {
            new Employee { firstName = "Joe", lastName = "Dirt", ID = 1 },
            new Employee { firstName = "Joe", lastName = "Biden", ID = 2 },
            new Employee { firstName = "Bob", lastName = "Dylan", ID = 3 },
            new Employee { firstName = "Jane", lastName = "Austin", ID = 4 },
            new Employee { firstName = "Paul", lastName = "Revere", ID=5 },
            new Employee { firstName = "Alfred", lastName = "Hitchcock", ID=6 },
            new Employee { firstName = "Amy", lastName = "Winehouse", ID=7 },
            new Employee { firstName = "Jimmy", lastName = "Hendrix", ID=8 },
            new Employee { firstName = "Kate", lastName = "Winslet", ID=9 },
            new Employee { firstName = "Paddy", lastName = "Pimblett", ID=10 },
        };

        //for each loop to find all joes

        List<Employee> joes1 = new List<Employee>();
        foreach (Employee emp in employees)
        {
            if (emp.firstName == "Joe")
            {
                joes1.Add(emp);
            }
        }

        Console.WriteLine("Joes (foreach loop):");
        foreach (var joe in joes1)
        {
            Console.WriteLine($"{joe.firstName} {joe.lastName}, Id: {joe.ID}");
        }

        //using lambda

        List<Employee> joes2 = employees.Where(e => e.firstName == "Joe").ToList();

        Console.WriteLine("\nJoes (lambda):");
        foreach (var joe in joes2)
        {
            Console.WriteLine($"{joe.firstName} {joe.lastName}, Id: {joe.ID}");
        }

        //lambda for employee id > 5

        List<Employee> idGreaterThanFive = employees.Where(e => e.ID > 5).ToList();

        Console.WriteLine("\nEmployees with Id > 5:");
        foreach (var emp in idGreaterThanFive)
        {
            Console.WriteLine($"{emp.firstName} {emp.lastName}, Id: {emp.ID}");
        }

    }
}