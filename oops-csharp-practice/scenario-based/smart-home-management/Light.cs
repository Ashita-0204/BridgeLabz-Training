class Light : IControllable, Appliances
{
    public void TurnOn()
    {
        Console.WriteLine("The Light is turned On");
    }
    public void TurnOff()
    {
        Console.WriteLine("The Light is turned Off");

    }
}