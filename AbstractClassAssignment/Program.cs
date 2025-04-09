using System;

class Program
{
    static void Main(string[] args)
    {
        //create instance of Employee class
        Employee employee = new Employee();
        employee.firstName = "Sample";
        employee.LastName = "Student";

        employee.SayName();
    }
}