using System;

class Program
{
    static void Main(string[] args)
    {
        //create employee
        Employee employee = new Employee
        {
            firstName = "Sample",
            lastName = "Student",
            Id = 1
        };

        employee.SayName();

        //employee object as an iquittable
        IQuittable quitter = employee;
        quitter.Quit();
    }
}