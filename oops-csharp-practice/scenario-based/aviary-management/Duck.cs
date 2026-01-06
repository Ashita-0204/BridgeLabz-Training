using System;
class Duck : Bird, ISwimmable
{
    public void Swim()
    {
        Console.WriteLine("It's a Duck");
    }
}