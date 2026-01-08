class Appliance
{
    public string Name
    {
        get; set;
    }
    //base class
    public virtual void Display()
    {
        Console.WriteLine("The appliance name is " + Name);
    }
}