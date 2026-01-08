class Home
{
    public static void Main()
    {
        IControllable[] appl = { new Light { Name = Khushi }, new Fan { Name = Sneha }, new AC { Name = Vaibhavi } };
        Console.WriteLine("Turning On/Off the Appliances");
        for (int i = 0; i < appl.Length; i++)
        {
            appl[i].TurnOn();
            appl[i].TurnOff();
        }
    }
}