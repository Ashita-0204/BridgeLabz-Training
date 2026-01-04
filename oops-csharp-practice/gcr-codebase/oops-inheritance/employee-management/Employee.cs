using System;
class Employee
{
    public string name;
    public int Id;
    public int salary;

    //virtual method
    public virtual void DisplayDetail()
    {
        Console.WriteLine("Employee Details");
    }
}