using System;
class VehicleHybridTest
{
    public static void Main()
    {
        // Creating objects of the PetrolVehicle and ElectricVehicle classes
        PetrolVehicle petrol = new PetrolVehicle();
        ElectricVehicle electric = new ElectricVehicle();

        // Refueling and charging the vehicles
        petrol.Refuel();
        electric.Charge();
    }
}
