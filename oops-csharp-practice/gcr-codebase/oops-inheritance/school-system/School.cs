using System;
class SchoolTest
{
    public static void Main()
    {
        Teacher teacher = new Teacher
        {
            Name = "Mrs. Rathee",
            Age = 30,
            Subject = "Physics"
        };

        // Displaying the teacher with the subject he teaches
        Console.WriteLine("Teacher: " + teacher.Name + " teaches Subject: " + teacher.Subject + " is of " + teacher.Age + " age.");
    }
}
