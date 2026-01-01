using System;
class Student
{
    //Initialization
    public int rollnum;
    protected string name;
    private double CGPA;
    //for private variable
    public void SetCgp(double cgp)
    {
        CGPA = cgp;
    }
    public double GetCgp()
    {
        return CGPA;
    }
}
//derived class 
class PostgraduateStudent : Student //for protected data
{
    public void SetName(string studentName)
    {
        name = studentName;
    }
    public void Display()
    {
        Console.WriteLine("Name: " + name);
    }
}

class UnivManagement
{
    public static void Main()
    {
        PostgraduateStudent pg = new PostgraduateStudent();
        pg.rollnum = 101;
        pg.SetName("Annural");
        pg.SetCgp(8.9);

        Console.WriteLine("Roll Number: " + pg.rollnum);
        Console.WriteLine("CGPA: " + pg.GetCgp());
        pg.Display();
    }
}