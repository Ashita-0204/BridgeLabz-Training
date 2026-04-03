using System;
using System.Diagnostics.Contracts;
class Customer
{
    public string Name { get; set; }
    //constructor
    public Customer(string name)
    {
        Name = name;
    }

    public void Display()
    {
        Console.WriteLine("Customer " + Name);
    }
}