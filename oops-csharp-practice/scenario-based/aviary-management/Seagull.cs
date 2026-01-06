public class Seagull : Bird, IFlyable, ISwimmable
{
    public void Fly()
    {
        Console.WriteLine("Seagull can fly");
    }

    public void Swim()
    {
        Console.WriteLine("Seagull can swim");
    }
}
