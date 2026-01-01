using System;
class Employee
{
    //global Variables
    public string name;
    public int id;
    public int salary;
    public void Display()
    { //method to print the data
        Console.WriteLine("Employee Name: " + name);
        Console.WriteLine("Employee ID: " + id);
        Console.WriteLine("Employee Salary: " + salary);
    }
}


class EmployeeDetails
{

    public static void Main()
    {
        //input for diff data
        Employee emp = new Employee();
        Console.Write("Enter Name ");
        emp.name = Console.ReadLine();
        Console.Write("Enter id ");
        emp.id = int.Parse(Console.ReadLine());
        Console.Write("Enter Salary ");
        emp.salary = int.Parse(Console.ReadLine());
        //printing those data
        emp.Display();

    }
}