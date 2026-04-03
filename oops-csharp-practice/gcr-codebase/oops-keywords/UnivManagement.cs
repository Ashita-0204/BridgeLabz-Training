using System;
class UnivManagement
{
    //static variable
    public static string UniversityName = "Peak University";
    private static int total = 0;
    //instance var
    public string name;
    public string grades;
    //readonly var
    public readonly int rollNum;
    //constructor
    public UnivManagement(string Name, int roll, string Grade)
    {
        this.name = Name;
        this.rollNum = roll;
        this.grades = Grade;
        total++;
    }
    //static method
    public static void DisplayTotal()
    {
        Console.WriteLine("Total Students: " + total);
    }

    public void Display()
    {
        if (this is UnivManagement)
        {
            Console.WriteLine(name + " has a Roll Number : " + rollNum + " has a Grade: " + grades);
        }
    }

    public static void Main()
    {
        UnivManagement student = new UnivManagement("Kriss", 35, "C");
        student.Display();
        DisplayTotal();
    }
}