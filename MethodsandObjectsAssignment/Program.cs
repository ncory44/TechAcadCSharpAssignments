using System;

class Program
{
    static void Main(string[] args)
    {
        //create a new instance of the employee class
        Employee employee = new Employee();
        employee.firstName = "Sample";
        employee.lastName = "Student";
        employee.Id = 117;

        //call the sayName method on the employee instance
        employee.sayName();
        Console.WriteLine(employee.Id);
    }
}