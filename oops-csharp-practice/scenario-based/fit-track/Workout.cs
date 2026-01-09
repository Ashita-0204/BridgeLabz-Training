using System;
class Workout
{
    public string WorkName { get; set; }
    public int duration { get; set; }
    //virtual method
    public virtual void Display()
    {
        Console.WriteLine(WorkName + " was done for " + duration + " mins.");
    }
}