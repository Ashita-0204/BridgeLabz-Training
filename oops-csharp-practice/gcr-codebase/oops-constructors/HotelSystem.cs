using System;
class Booking
{
    //variable
    public string name;
    public string type;
    public int nights;

    //default constructor
    public Booking()
    {
        name = "Reshi";
        type = "Deluxe";
        nights = 5;
    }

    //Parameterized Constructor
    public Booking(string name, string type, int nights)
    {
        this.name = name;
        this.type = type;
        this.nights = nights;
    }

    //copy constructor
    public Booking(Booking books)
    {
        name = books.name;
        type = books.type;
        nights = books.nights;
    }

    public void Display()
    {
        Console.WriteLine("The name is " + name + " and the type of room is " + type + " for " + nights + " nights");
    }
}

class HotelSystem
{
    public static void Main()
    {
        Booking booking = new Booking();
        Booking booking1 = new Booking("Keshi", "Standard", 5);
        Booking booking2 = new Booking(booking1);

        booking.Display();
        booking1.Display();
        booking2.Display();
    }
}