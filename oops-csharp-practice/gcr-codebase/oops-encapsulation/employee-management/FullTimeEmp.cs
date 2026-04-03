using System;
class FullTimeEmp : Employee, IDepartment
{
    private string department;
    public FullTimeEmp(int salary)
    {
        baseSalary = salary;
    }
    public override int CalculateSalary()
    {
        return baseSalary;
    }
    public void AssignDept(string dept)
    {
        department = dept;
    }
    public string GetDeptDetail()
    {
        return department;
    }
}