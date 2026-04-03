using System;
// Manager inherits employee
public class Manager : Employee
{
    public int TeamSize;

    // Overriden method
    public override void DisplayDetails()
    {
        Console.WriteLine("Manager with team size: " + TeamSize);
    }
}
