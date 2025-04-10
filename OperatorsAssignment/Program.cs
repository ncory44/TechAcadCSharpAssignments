using System;

class Program
{
    static void Main(string[] args)
    {
        Employee employee1 = new Employee { firstName = "John", lastName = "Lennon", Id = 1 };
        Employee employee2 = new Employee { firstName = "Paul", lastName = "McCartney", Id = 2 };
        Employee employee3 = new Employee { firstName = "George", lastName = "Harrison", Id = 1 };
        Employee employee4 = new Employee { firstName = "Ringo", lastName = "Starr", Id = 4 };


        if (employee1 == employee3)
        {
            Console.WriteLine("John and George are the same.");
        }
        else
        {
            Console.WriteLine("John and George are different.");
        }

        if (employee2 != employee4)
        {
            Console.WriteLine("Paul and Ringo are different.");
        }
        else
        {
            Console.WriteLine("Paul and Ringo are the same.");
        }
    }
}