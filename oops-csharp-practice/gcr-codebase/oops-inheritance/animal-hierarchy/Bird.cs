using System;
//birds inherit animal
public class Bird : Animal
{
    //overriden method
    public override void MakeSound()
    {
        Console.WriteLine("Chirps");
    }
}