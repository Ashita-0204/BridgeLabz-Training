using System;
//inherits 
class Developer : Employee
{
    string ProgrammingLanguage = "Java";
    public void DisplayDetail()
    {
        Console.WriteLine("The programming language used by the developer is " + ProgrammingLanguage);
    }
}