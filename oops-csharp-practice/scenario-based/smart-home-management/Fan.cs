class Fan : IControllable, Appliances
{
    public void TurnOn()
    {
        Console.WriteLine("The Fan is turned On");
    }
    public void TurnOff()
    {
        Console.WriteLine("The Fan is turned Off");
    }
}