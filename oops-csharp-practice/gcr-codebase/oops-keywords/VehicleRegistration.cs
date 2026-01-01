using System;
class VehicleRegistration
{
    // static variable
    public static int RegistrationFee = 2000;

    // instance variable
    public string OwnerName;
    public string VehicleType;

    // readonly variable
    public readonly string RegistrationNumber;

    // constructor 
    public VehicleRegistration(string owner, string type, string regNum)
    {
        this.OwnerName = owner;
        this.VehicleType = type;
        this.RegistrationNumber = regNum;
    }

    // static method 
    public static void Update(int fee)
    {
        RegistrationFee = fee;
    }

    public void Display()
    {
        if (this is VehicleRegistration)
        {
            Console.WriteLine(OwnerName + " owns " + VehicleType + " with a Registration Number " + RegistrationNumber);
        }
    }

    public static void Main()
    {
        VehicleRegistration vehicle = new VehicleRegistration("Isha", "Car", "MH78001256");
        vehicle.Display();
        vehicle.Update(95000);
    }
}
