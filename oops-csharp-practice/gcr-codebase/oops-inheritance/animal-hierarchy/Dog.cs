using System;
//Dog inherits animal
public class Dog : Animal
{
    //overriden method
    public override void MakeSound()
    {
        Console.WriteLine("Barks");
    }
}