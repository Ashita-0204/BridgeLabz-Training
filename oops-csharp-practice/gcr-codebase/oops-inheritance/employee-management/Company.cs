using System;
class Company
{
    public static void Main()
    {
        Employee emp1 = new Manager { TeamSize = 4 };
        Employee emp2 = new Developer { ProgrammingLanguage = "Java" };
        Employee emp3 = new Intern { InternshipDuration = "6 Months" };

        emp1.DisplayDetails();
        emp2.DisplayDetails();
        emp3.DisplayDetails();
    }
}