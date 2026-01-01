using System;
using System.Security.Cryptography;

class Course
{
    //instance variables
    public string Coursename;
    public int duration;
    public int fees;
    //class variables
    public static string instituteName = "Starry";
    //constructor
    public Course(string name, int duration, double fees)
    {
        this.Coursename = name;
        this.duration = duration;
        this.fees = fees;
    }
    //instance method
    public void Display()
    {
        Console.WriteLine("Course Name: " + Coursename);
        Console.WriteLine("Duration: " + duration + " months");
        Console.WriteLine("Fee: " + fees);
        Console.WriteLine("Institute name : " + instituteName);
    }

    //class method
    public static void Update(string newName)
    {
        instituteName = newName;
    }

}
class CourseManagement
{
    public static void Main()
    {
        Course course = new Course("Maths", 2, 2000);
        course.Display();
        Course.Update("Cisco");
        course.Display();


    }
}