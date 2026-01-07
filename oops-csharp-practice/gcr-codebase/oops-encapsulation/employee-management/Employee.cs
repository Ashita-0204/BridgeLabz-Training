using System;
public abstract class Employee
{
    private int employeeId;
    private string name;
    protected int baseSalary;
    public int employeeId
    {
        get => employeeId; set => employeeId = value;
    }
    public string name
    {
        get => name; set => name = value;
    }

    public abstract int CalculateSalary();
    public void Display()
    {
        Console.WriteLine("ID: " + EmployeeId);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Salary: " + CalculateSalary());
    }
}