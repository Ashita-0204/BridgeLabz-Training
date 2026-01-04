using System;
//cat inherits animal
public class Cat : Animal
{
    //overriden method
    public override void MakeSound()
    {
        Console.WriteLine("Meows");
    }
}