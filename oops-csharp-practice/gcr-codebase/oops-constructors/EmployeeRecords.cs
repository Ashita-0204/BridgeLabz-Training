using System;
class Employee
{
    //variables
    public int empId;
    protected string Department;
    private int salary;

    //method for private salary
    public void SetSalary(int amt)
    {
        salary = amt;
    }
    public int getSalary()
    {
        return salary;
    }
}
//derived class
class Manager : Employee
{
    public void setDepartment(string dept)
    {
        Department = dept;
    }
    public void Display()
    {
        Console.WriteLine("Employee ID: " + empId);
        Console.WriteLine("Department: " + Department);
    }

}
class EmployeeRecords
{
    public static void Main()
    {
        Manager manage = new Manager();
        manage.empId = 462;
        manage.setDepartment("CSE");
        manage.SetSalary(78964);
        manage.Display();
        Console.WriteLine("Salary: " + manage.getSalary());

    }
}