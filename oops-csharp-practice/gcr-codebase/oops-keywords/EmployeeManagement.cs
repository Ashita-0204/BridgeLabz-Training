using System;
class EmployeeManagement
{
    //static variable
    public static string CompanyName = "TechJunk";
    private static int total = 0;
    //instance variable
    public string name;
    public string designation;
    //readonly
    readonly int iD;
    // constructor  
    public Employee(string Name, int id, string Designation)
    {
        this.name = Name;
        this.iD = id;
        this.designation = Designation;
        total++;
    }
    //static method
    public static void DisplayEmp()
    {
        Console.WriteLine("Total Employees: " + total);
    }

    public void Display()
    {
        if (this is Employee)
        {
            Console.WriteLine(name + " with " + designation + " with ID: " + iD);
        }
    }

    public static void Main()
    {
        EmployeeManagement emp = new EmployeeManagement("Sneha", 85, "Developer");
        emp.Display();
        DisplayEmp();
    }
}