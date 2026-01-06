using System;
class Bird
{
    string Name;
    string Species;

    public virtual void Display()
    {
        Console.WriteLine("The bird name is " + Name);
        Console.WriteLine("The species is " + Species);
    }
}