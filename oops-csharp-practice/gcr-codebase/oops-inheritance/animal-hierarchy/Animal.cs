public class Animal
{
    //Variables
    public string name;
    public int age;
    //virtual method to be overriden
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes sound");
    }

}