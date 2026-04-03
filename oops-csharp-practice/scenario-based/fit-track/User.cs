using System;
class User
{
    public int id { get; set; }
    public string name { get; set; }
    //display
    public void Display()
    {
        Console.WriteLine("The user with " + id + " is " + name);
    }
}