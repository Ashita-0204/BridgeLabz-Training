using System;
class Intern : Employee
{
    string InternshipDuration = "6 months";
    //overriden method
    public void DisplayDetails()
    {
        Console.WriteLine("The internship duration is " + InternshipDuration);
    }
}