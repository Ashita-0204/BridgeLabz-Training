// Inherits from the Vehicle class
class PetrolVehicle : Vehicle, Refuelable
{
    // Method to refuel the vehicle
    public void Refuel()
    {
        Console.WriteLine("Refueling petrol vehicle");
    }
}
