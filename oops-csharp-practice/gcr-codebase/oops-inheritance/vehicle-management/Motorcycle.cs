// Motorcycle inherits Vehicle
public class Motorcycle : Vehicle
{
    public bool HasSidecar;
    //overriden method
    public override void DisplayInfo()
    {
        Console.WriteLine("Has sidecar: " + HasSidecar);
    }
}
